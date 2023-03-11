﻿using CustomerApi.Models;
using CustomerApi.Models.SubModel;
using CustomerApi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Repository
{
    public class CustomerRepository : ICustomerRepository
    {

        private readonly CustomerDbContext _db;
        public CustomerRepository(CustomerDbContext db)
        {
            _db = db;
        }
        public List<ResponseCustomers_GetAll> GetAll()
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
            var result = _db.Set<ResponseCustomers_GetAll>().FromSqlRaw(sql).ToList();
            return result;
        }
        public ResponseCustomers_Get Get(int IdCustomer)
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
            var result = _db.Set<ResponseCustomers_Get>().FromSqlRaw(sql, new { prmIdCustomer = IdCustomer }).FirstOrDefault();
            return result;
        }

    }
}
