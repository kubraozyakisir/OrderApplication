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
            if (!_orderDbContext.Products.Any())
            {
                var products = new List<Products>()
                {
                    new Products()
                    {
                        IdProduct=1,
                        ImageUrl="www.xxx.com/1.png",
                        ProductName="Kitap"
                    },
                      new Products()
                     {
                        IdProduct=2,
                        ImageUrl="www.xxx.com/2.png",
                        ProductName="Çanta"
                    },
                };
                _orderDbContext.Products.AddRange(products);
                _orderDbContext.SaveChanges();
            }
        }
    }
}
