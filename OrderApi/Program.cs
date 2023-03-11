using Microsoft.EntityFrameworkCore;
using OrderApi.Models;
using OrderApi.Repository;
using OrderApi.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);

//add connection
var connectionString = builder.Configuration.GetConnectionString("AppDbOrder");
builder.Services.AddTransient<DataSeeder>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddDbContext<OrderDbContext>(x => x.UseSqlServer(connectionString));
// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

if (args.Length == 1 && args[0].ToLower() == "seeddata")
    SeedData(app);

void SeedData(IHost app)
{
    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

    using (var scope = scopedFactory.CreateScope())
    {
        var service = scope.ServiceProvider.GetService<DataSeeder>();
        service.Seed();
    }
}
// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
