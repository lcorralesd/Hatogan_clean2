using Dapper;
using Hatogan.EB.Abstractions.Interfaces;
using Hatogan.EB.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hatogan.IA.Gateways.Dapper
{
    public class DapperBreedRepository : IDapperBreedRepository
    {
        private readonly DapperContext _context;

        public DapperBreedRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Breed>> GetAll()
        {
            using IDbConnection db = _context.CreateConnection();
            db.Open();
            string sql = $"select *  from dbo.Breeds";
            var result = await db.QueryAsync<Breed>(sql);
            return result.ToList();
        }

        public async Task<Breed> GetByName(string name)
        {
            using IDbConnection db = _context.CreateConnection();
            db.Open();
            string sql = $"select *  from dbo.Breeds where Name = @Name";
            var result = await db.QuerySingleOrDefaultAsync<Breed>(sql, new { Name = name });
            return result;
        }

        public async Task<Breed> GetById(int id)
        {
            using IDbConnection db = _context.CreateConnection();
            db.Open();
            string sql = $"select *  from dbo.Breeds where Id = @Id";
            var result = await db.QuerySingleOrDefaultAsync<Breed>(sql, new { Id = id });
            return result;
        }
    }
}
