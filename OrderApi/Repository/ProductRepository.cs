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
             SELECT 
                  IdOrder, 
                  IdCustomer, 
                  Quantity, 
                  Price, 
                  OrderStatus, 
                  IdAddress, 
                  IdProduct, 
                  CreatedDate, 
                  UpdatedDate 
                FROM  Orders ";
            var result = _db.Connection.Query<ResponseProducts_GetAll>(sql).ToList();
            return result;

        }
        public ResponseProducts_Get Get(int IdProduct)
        {
            var sql = @"
             SELECT 
                  IdOrder, 
                  IdCustomer, 
                  Quantity, 
                  Price, 
                  OrderStatus, 
                  IdAddress, 
                  IdProduct, 
                  CreatedDate, 
                  UpdatedDate 
                FROM  Orders where IdOrder= @prmIdOrder";
            var result = _db.Connection.Query<ResponseProducts_Get>(sql, new { prmIdOrder = IdProduct }).FirstOrDefault();
            return result;

        }
    }
}
