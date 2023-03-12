using CustomerApi.Models;
using CustomerApi.Models.SubModel;
using CustomerApi.Repository.Interfaces;
using Dapper;
using Microsoft.EntityFrameworkCore;
using System.Net;

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
             SELECT IdCustomer,
                   CustomerName,
                   Email,
                   a.AddressLine,
                   CreatedDate,
                   UpdatedDate
            FROM Customers c
            LEFT JOIN Addresses a ON c.IdAddress=a.IdAddress";
            var result = _db.Connection.Query<ResponseCustomers_GetAll>(sql).ToList();
            return result;

        }
        public ResponseCustomers_Get Get(int IdCustomer)
        {
            var sql = @"
            --DECLARE @prmIdCustomer int=3
                SELECT IdCustomer,
                       CustomerName,
                       Email,
                       a.AddressLine,
                       CreatedDate,
                       UpdatedDate
                FROM Customers c
                LEFT JOIN Addresses a ON c.IdAddress=a.IdAddress
                WHERE IdCustomer=@prmIdCustomer";
            var result = _db.Connection.Query<ResponseCustomers_Get>(sql, new { prmIdCustomer = IdCustomer }).FirstOrDefault();
            return result;
        }

    }
}
