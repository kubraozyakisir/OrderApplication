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
            var result = _db.Set<ResponseOrders_GetAll>().FromSqlRaw(sql).ToList();
            return result;
        }
        public ResponseOrders_Get Get(int IdOrder)
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
            var result = _db.Set<ResponseOrders_Get>().FromSqlRaw(sql, new { prmIdOrder = IdOrder }).FirstOrDefault();
            return result;
        }
    }
}
