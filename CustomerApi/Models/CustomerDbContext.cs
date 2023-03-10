using Microsoft.EntityFrameworkCore;

namespace CustomerApi.Models
{
    public class CustomerDbContext:DbContext
    {
        public CustomerDbContext()
        {

        }
        public CustomerDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Customer> Customer { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").
                Build();
            var connectionString = configuration.GetConnectionString("AppDbCustomer");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
