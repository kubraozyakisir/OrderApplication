using Dapper;
using Microsoft.EntityFrameworkCore;
using OrderApi.Models;
using OrderApi.Models.SubModel;
using OrderApi.Repository.Interfaces;
using System.Net;

namespace OrderApi.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly OrderDbContext _db;

        public ProductRepository(OrderDbContext db)
        {
            _db = db;
        }
        public List<ResponseProducts_GetAll> GetAll()
        {
            var sql = @"
                SELECT IdProduct,
                       ImageUrl,
                       ProductName
                  FROM Products";
            var result = _db.Connection.Query<ResponseProducts_GetAll>(sql).ToList();
            return result;

        }
        public ResponseProducts_Get Get(int IdProduct)
        {
            var sql = @"
                    --DECLARE @prmIdProduct int=1
                    
                    SELECT IdProduct,
                           ImageUrl,
                           ProductName
                    FROM Products
                    WHERE IdProduct=@prmIdProduct";
            var result = _db.Connection.Query<ResponseProducts_Get>(sql, new { prmIdProduct = IdProduct }).FirstOrDefault();
            return result;

        }
    }
}
