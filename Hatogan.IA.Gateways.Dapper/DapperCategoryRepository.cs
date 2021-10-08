using Dapper;
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
    public class DapperCategoryRepository : IDapperCategoryRepository
    {
        private readonly DapperContext _context;

        public DapperCategoryRepository(DapperContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            using IDbConnection db = _context.CreateConnection();
            db.Open();
            string sql = $"select *  from dbo.Categories";
            var result = await db.QueryAsync<Category>(sql);
            return result.ToList();
        }

        public async Task<Category> GetById(int id)
        {
            using IDbConnection db = _context.CreateConnection();
            db.Open();
            string sql = $"select *  from dbo.Categories where Id = @Id";
            var result = await db.QuerySingleOrDefaultAsync<Category>(sql, new { Id = id });
            return result;
        }
    }
}
