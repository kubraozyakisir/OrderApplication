using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace OrderApi.Models
{
    public class OrderDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        private string _connectionString;
        private IDbConnection? _connection { get; set; }
        public OrderDbContext(IConfiguration configuration, DbContextOptions options) : base(options)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("AppDbOrder");
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
        public IDbConnection Connection
        {
            get
            {
                if (_connection == null || string.IsNullOrEmpty(_connection.ConnectionString))
                {
                    _connection = CreateConnection();
                    if (_connection.State != ConnectionState.Open)
                    {
                        _connection.Open();
                    }
                    return _connection;
                }
                return _connection;
            }
        }
        public IDbConnection CreateConnection() => new SqlConnection(_connectionString);

        public void SetDatabase(string databaseName)
        {
            _connectionString = _connectionString.Replace("XXX", databaseName);
        }

        public void Close()
        {
            if (_connection != null && _connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        public void Dispose()
        {
            Close();
        }
    }
}
