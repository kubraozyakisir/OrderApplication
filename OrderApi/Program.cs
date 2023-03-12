using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OrderApi.Business.Dependency;
using OrderApi.Business.MapperProfile;
using OrderApi.Models;
using OrderApi.Repository;
using OrderApi.Repository.Interfaces;

var builder = WebApplication.CreateBuilder(args);
//for using controller
builder.Services.AddControllers().AddJsonOptions(jsonOptions => jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null);


//add connection
var connectionString = builder.Configuration.GetConnectionString("AppDbOrder");
builder.Services.AddTransient<DataSeeder>();
builder.Services.AddDbContext<OrderDbContext>(x => x.UseSqlServer(connectionString));
 

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region Auto Mapper

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new OrderApiProfile());
});

var mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

#endregion Auto Mapper

builder.Services.AddOrderApiServices();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

//if (args.Length == 1 && args[0].ToLower() == "seeddata")
//    SeedData(app);

//void SeedData(IHost app)
//{
//    var scopedFactory = app.Services.GetService<IServiceScopeFactory>();

//    using (var scope = scopedFactory.CreateScope())
//    {
//        var service = scope.ServiceProvider.GetService<DataSeeder>();
//        service.Seed();
//    }
//}
// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
