using CustomerApi.Models;
using CustomerApi.Models.SubModel;
using CustomerApi.Repository.Interfaces;
using Dapper;
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
           SELECT IdAddress,
                   AddressLine,
                   City,
                   Country,
                   Code
            FROM Addresses";
            //var result = _db.Set<ResponseAddresses_GetAll>().FromSqlRaw(sql).ToList();
            //return result;
            var result = _db.Connection.Query<ResponseAddresses_GetAll>(sql).ToList();
            return result;
        }
        public ResponseAddresses_Get Get(int IdAddress)
        {
            var sql = @"
              --DECLARE @prmIdAddress int=1
                SELECT IdAddress,
                       AddressLine,
                       City,
                       Country,
                       Code
                FROM Addresses
                WHERE IdAddress=@prmIdAddress";
            var result = _db.Connection.Query<ResponseAddresses_Get>(sql, new { prmIdAddress = IdAddress }).FirstOrDefault();
            return result;
        }
    }
}
