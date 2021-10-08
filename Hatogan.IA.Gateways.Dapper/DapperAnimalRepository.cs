using Dapper;
using Hatogan.AB.UseCases.DTOs.Animals;
using Hatogan.AB.UseCases.DTOs.Breeds;
using Hatogan.AB.UseCases.DTOs.Categories;
using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.EB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Gateways.Dapper
{
    public class DapperAnimalRepository : IDapperAnimalRepository
    {
        private readonly DapperContext _context;

        public DapperAnimalRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Animal>> GetAll()
        {
            using IDbConnection db = _context.CreateConnection();
            db.Open();
            string sql = @$"select a.Id, a.Code, a. EarTag, a.Name, a.Color, a.Sex,
                                   a.[Status], f.Code as Farm, b.Name as Breed, c.Name as Category, a.BirthDate,
                                   a.BirthWeight, a.AdmissionDate, a.IncomeWeight, a.ImageUrl, a.Remark 
                            from (((dbo.Animals as a
                            inner join dbo.Breeds as b
                            on a.BreedId = b.Id)
                            inner join dbo.Categories as c
                            on a.CategoryId = c.Id)
                            inner join dbo.Farms as f
                            on a.FarmId = f.Id)";
            var result = await db.QueryAsync<Animal, Breed, Category, Animal>(sql, (animal, breed, category ) =>
            {
                animal.Breed = breed;
                animal.Category = category;
                return animal;
            }, splitOn: "BreedId");
            return result.ToList();
        }

        public async Task<Animal> GetByCode(string code)
        {
            using IDbConnection db = _context.CreateConnection();
            db.Open();
            string sql = @$"select *  from dbo.Animals where Code = @Code";

            var result = await db.QuerySingleOrDefaultAsync<Animal>(sql, new { Code = code });
            return result;
        }

        public async Task<Animal> GetById(int id)
        {
            using IDbConnection db = _context.CreateConnection();
            db.Open();
            string sql = @$"select a.Id, a.Code, a. EarTag, a.Name, a.Color, a.Sex,
                                   a.[Status], f.Code, b.Name, c.Name, a.BirthDate,
                                   a.BirthWeight, a.AdmissionDate, a.IncomeWeight, a.ImageUrl, a.Remark 
                            from (((dbo.Animals as a
                            inner join dbo.Breeds as b
                            on a.BreedId = b.Id)
                            inner join dbo.Categories as c
                            on a.CategoryId = c.Id)
                            inner join dbo.Farms as f
                            on a.FarmId = f.Id)
                            where Id = @Id";
            var result = await db.QuerySingleOrDefaultAsync<Animal>(sql, new { Id = id });
            return result;
        }
    }
}
