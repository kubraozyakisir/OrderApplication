using CustomerApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//add connection
var connectionString = builder.Configuration.GetConnectionString("AppDbCustomer");
builder.Services.AddTransient<DataSeeder>();
builder.Services.AddDbContext<CustomerDbContext>(x => x.UseSqlServer(connectionString));


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