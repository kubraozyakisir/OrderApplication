using AutoMapper;
using CustomerApi.Models.SubModel;
using CustomerApi.Models;
using System.Net;

namespace CustomerApi.Business.Mapper
{
    public class CustomerApiProfile : Profile
    {
        public CustomerApiProfile()
        {
            #region Customer
            CreateMap<Customers, ResponseCustomers_Get>();
            CreateMap<Customers, ResponseCustomers_GetAll>();
            CreateMap<Customers, RequestCustomers>();
            CreateMap<RequestCustomers, Customers>();
            #endregion Customer

            #region Address
            CreateMap<Addresses, ResponseAddresses_Get>();
            CreateMap<Addresses, ResponseAddresses_GetAll>();
            CreateMap<Addresses, RequestAddresses>();
            CreateMap<RequestAddresses, Addresses>();
            #endregion Address

        }
    }
}