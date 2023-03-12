using Dapper;
using Microsoft.EntityFrameworkCore;
using OrderApi.Models;
using OrderApi.Models.SubModel;
using OrderApi.Repository.Interfaces;

namespace OrderApi.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly OrderDbContext _db;

        public OrderRepository(OrderDbContext db)
        {
            _db = db;
        }
        public List<ResponseOrders_GetAll> GetAll()
        {
            var sql = @"
             SELECT IdOrder,
                    IdCustomer,
                    p.ProductName,
                    p.ImageUrl,
                    Quantity,
                    Price,
                    OrderStatus,
                    IdAddress,
                    CreatedDate,
                    UpdatedDate
            FROM Orders o
            LEFT JOIN Products p ON o.IdProduct=p.IdProduct";
            var result = _db.Connection.Query<ResponseOrders_GetAll>(sql).ToList();
            return result;
        }
        public ResponseOrders_Get Get(int IdOrder)
        {
            var sql = @"
             --DECLARE @prmIdOrder int=3
                SELECT IdOrder,
                       IdCustomer,
                       p.ProductName,
                       p.ImageUrl,
                       Quantity,
                       Price,
                       OrderStatus,
                       IdAddress,
                       CreatedDate,
                       UpdatedDate
                FROM Orders o
                LEFT JOIN Products p ON o.IdProduct=p.IdProduct
                WHERE o.IdOrder=@prmIdOrder";
            var result = _db.Connection.Query<ResponseOrders_Get>(sql, new { prmIdOrder = IdOrder }).FirstOrDefault();
            return result;
        }
    }
}
