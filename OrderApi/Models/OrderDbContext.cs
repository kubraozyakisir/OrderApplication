using Microsoft.EntityFrameworkCore;

namespace OrderApi.Models
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext()
        {
        }
        public OrderDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Orders> Orders { get; set; }
        public DbSet<Products> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").
                Build();
            var connectionString = configuration.GetConnectionString("AppDbOrder");
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
