using CustomerApi.Models;
using CustomerApi.Models.SubModel;
using CustomerApi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Repository
{
    public class AddressRepository : IAddressRepository
    {
        private readonly CustomerDbContext _db;
        public AddressRepository(CustomerDbContext db)
        {
            _db = db;
        }
        public List<ResponseAddresses_GetAll> GetAll()
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
            var result = _db.Set<ResponseAddresses_GetAll>().FromSqlRaw(sql).ToList();
            return result;
        }
        public ResponseAddresses_Get Get(int IdAddress)
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
                FROM  Orders where IdAddress= @prmIdAddress";
            var result = _db.Set<ResponseAddresses_Get>().FromSqlRaw(sql, new { prmIdAddress = IdAddress }).FirstOrDefault();
            return result;
        }
    }
}
