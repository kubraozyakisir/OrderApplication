using OrderApi.Business.Interfaces;
using OrderApi.Repository;
using OrderApi.Repository.Interfaces;

namespace OrderApi.Business.Dependency
{
    public static class OrderApiDependency
    {
        public static void AddOrderApiServices(this IServiceCollection serviceCollection)
        {
            #region Order

            serviceCollection.AddScoped<IOrderBusiness, OrderBusiness>();
            serviceCollection.AddScoped<IOrderRepository, OrderRepository>();

            #endregion Order

            #region Product

            serviceCollection.AddScoped<IProductBusiness, ProductBusiness>();
            serviceCollection.AddScoped<IProductRepository, ProductRepository>();

            #endregion Product

        }
    }
}
