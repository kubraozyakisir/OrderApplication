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
            if (!customerDbContext.Customer.Any())
            {
                var customers = new List<Customer>()
                {
                    new Customer()
                    {
                        IdCustomer = 1,
                        CustomerName="Sezen Altan",
                        Email="sezenaltan@gmail.com",
                        IdAddress=1,
                        CreatedDate=DateTime.Now,
                        UpdatedDate=null
                    },
                      new Customer()
                     {
                        IdCustomer = 2,
                        CustomerName="Ali Sayar",
                        Email="alisayar@gmail.com",
                        IdAddress=2,
                        CreatedDate=DateTime.Now,
                        UpdatedDate=null
                    },

                };
                customerDbContext.Customer.AddRange(customers);
                customerDbContext.SaveChanges();
            }
            if (!customerDbContext.Address.Any())
            {
                var address = new List<Address>()
                {
                    new Address()
                    {
                        IdAddress=1,
                        AddressLine="Bebek",
                        City="İstanbul",
                        Country="Türkiye",
                        Code="34360"
                       
                    },
                      new Address()
                     {
                        IdAddress=2,
                        AddressLine="Erenköy",
                        City="İstanbul",
                        Country="Türkiye",
                        Code="34380"

                    },

                };
                customerDbContext.Address.AddRange(address);
                customerDbContext.SaveChanges();
            }

        }
    }
}
