using AutoMapper;
using CustomerApi.Business.Interfaces;
using CustomerApi.Repository;
using CustomerApi.Repository.Interfaces;

namespace CustomerApi.Business.Dependency
{
    public static class CustomerApiDependency
    {
        public static void AddCustomerApiServices(this IServiceCollection serviceCollection)
        {
            #region Customer

            serviceCollection.AddScoped<ICustomerBusiness, CustomerBusiness>();
            serviceCollection.AddScoped<ICustomerRepository, CustomerRepository>();

            #endregion Customer

            #region Address

            serviceCollection.AddScoped<IAddressBusiness, AddressBusiness>();
            serviceCollection.AddScoped<IAddressRepository, AddressRepository>();

            #endregion Address

        }
    }
}
