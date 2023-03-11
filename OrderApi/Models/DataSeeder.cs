using System.Net;

namespace OrderApi.Models
{
    public class DataSeeder
    {
        private readonly OrderDbContext _orderDbContext;
        public DataSeeder(OrderDbContext orderDbContext)
        {
            _orderDbContext = orderDbContext;
        }

        public void Seed()
        {
            if (!_orderDbContext.Orders.Any())
            {
                var orders = new List<Orders>()
                {
                    new Orders()
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
                      new Orders()
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
                _orderDbContext.Orders.AddRange(orders);
                _orderDbContext.SaveChanges();
            }
            if (!_orderDbContext.Product.Any())
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
                _orderDbContext.Product.AddRange(products);
                _orderDbContext.SaveChanges();
            }
        }
    }
}
