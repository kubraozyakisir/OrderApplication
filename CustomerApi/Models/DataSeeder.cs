namespace CustomerApi.Models
{
    public class DataSeeder
    {
 
        private readonly CustomerDbContext customerDbContext;
        public DataSeeder(CustomerDbContext customerDbContext)
        {
            this.customerDbContext = customerDbContext;
        }
       
        public void Seed()
        {
            if (!customerDbContext.Customers.Any())
            {
                var customers = new List<Customers>()
                {
                    new Customers()
                    {
                        IdCustomer = 1,
                        CustomerName="Sezen Altan",
                        Email="sezenaltan@gmail.com",
                        IdAddress=1,
                        CreatedDate=DateTime.Now,
                        UpdatedDate=null
                    },
                      new Customers()
                     {
                        IdCustomer = 2,
                        CustomerName="Ali Sayar",
                        Email="alisayar@gmail.com",
                        IdAddress=2,
                        CreatedDate=DateTime.Now,
                        UpdatedDate=null
                    },

                };
                customerDbContext.Customers.AddRange(customers);
                customerDbContext.SaveChanges();
            }
            if (!customerDbContext.Addresses.Any())
            {
                var address = new List<Addresses>()
                {
                    new Addresses()
                    {
                        IdAddress=1,
                        AddressLine="Bebek",
                        City="İstanbul",
                        Country="Türkiye",
                        Code="34360"
                       
                    },
                      new Addresses()
                     {
                        IdAddress=2,
                        AddressLine="Erenköy",
                        City="İstanbul",
                        Country="Türkiye",
                        Code="34380"

                    },

                };
                customerDbContext.Addresses.AddRange(address);
                customerDbContext.SaveChanges();
            }

        }
    }
}
