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
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Addresses> Addresses { get; set; }

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
