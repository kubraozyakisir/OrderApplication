using CustomerApi.Models.SubModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;

namespace CustomerApi.Models
{
    public class CustomerDbContext:DbContext,IDisposable
    {
        private readonly IConfiguration _configuration;
        private string _connectionString;
        private IDbConnection? _connection { get; set; }
     
        public CustomerDbContext(IConfiguration configuration,DbContextOptions options) : base(options)
        {
            _configuration = configuration;
            _connectionString = _configuration.GetConnectionString("AppDbCustomer");
        }

        public   DbSet<Customers> Customers { get; set; }
        public   DbSet<Addresses> Addresses { get; set; }
        public DbSet<ResponseAddresses_Get> ResponseAddresses_Get { get; set; }
        public DbSet<ResponseAddresses_GetAll> ResponseAddresses_GetAll { get; set; }
        //  public DbSet<ResponseCustomers_Get> ResponseCustomers_Get { get; set; }
        //  public DbSet<ResponseCustomers_GetAll> ResponseCustomers_GetAll { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory()).
                AddJsonFile("appsettings.json").
                Build();
            var connectionString = configuration.GetConnectionString("AppDbCustomer");
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
