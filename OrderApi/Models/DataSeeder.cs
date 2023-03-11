using System.Net;
using OrderApi.Repository;

namespace OrderApi.Models
{
    public class DataSeeder
    {
        private readonly OrderDbContext orderDbContext;
        public DataSeeder(OrderDbContext customerDbContext)
        {
            this.orderDbContext = customerDbContext;
        }

        public void Seed()
        {
            if (!orderDbContext.Order.Any())
            {
                var orders = new List<Order>()
                {
                    new Order()
                    {                               
                        IdOrder = 1,
                        IdCustomer=1,
                        Quantity=10,
                        Price=100,
                        OrderStatus="Kargoda",
                        IdAddress=1,
                        IdProduct=1,
                        CreatedDate=DateTime.Now,
                        UpdatedDate=null
                    },
                      new Order()
                     {
                        IdOrder = 2,
                        IdCustomer=2,
                        Quantity=10,
                        Price=200,
                        OrderStatus="Yolda",
                        IdAddress=2,
                        IdProduct=2,
                        CreatedDate=DateTime.Now,
                        UpdatedDate=null
                    },

                };
                orderDbContext.Order.AddRange(orders);
                orderDbContext.SaveChanges();
            }
            if (!orderDbContext.Product.Any())
            {
                var products = new List<Product>()
                {
                    new Product()
                    {
                        IdProduct=1,
                        ImageUrl="www.xxx.com/1.png",
                        ProductName="Kitap"
                    },
                      new Product()
                     {
                        IdProduct=2,
                        ImageUrl="www.xxx.com/2.png",
                        ProductName="Çanta"
                    },
                };
                orderDbContext.Product.AddRange(products);
                orderDbContext.SaveChanges();
            }
        }
    }
}
