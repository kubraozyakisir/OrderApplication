using AutoMapper;
using CustomerApi.Business;
using CustomerApi.Business.Dependency;
using CustomerApi.Business.Interfaces;
using CustomerApi.Business.Mapper;
using CustomerApi.Models;
using CustomerApi.Models.SubModel;
using CustomerApi.Repository;
using CustomerApi.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddJsonOptions(jsonOptions => jsonOptions.JsonSerializerOptions.PropertyNamingPolicy = null);

//add connection
var connectionString = builder.Configuration.GetConnectionString("AppDbCustomer");
builder.Services.AddTransient<DataSeeder>();
builder.Services.AddDbContext<CustomerDbContext>(x => x.UseSqlServer(connectionString));


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add services to the container.

//builder.Services.AddControllers();


#region Auto Mapper

var mappingConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new CustomerApiProfile());
});

var mapper = mappingConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

#endregion Auto Mapper


builder.Services.AddCustomerApiServices();

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

//app.UseAuthorization();

app.MapControllers();

app.Run();
