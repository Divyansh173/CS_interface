using API_APPS.Models;
using Microsoft.EntityFrameworkCore;
using API_APPS.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Register the eShoppingCodiContext in DI Container
// Also provide the ConnectionString for SQL Server
builder.Services.AddDbContext<eShoppingCodiContext>(options => 
{
    // Pass the Connection String
    // using the builder.Configuration.ConnectionString
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));
});

builder.Services.AddScoped<IDbAccessService<Category, int>, CategoryDataAccess>();
builder.Services.AddScoped<IDbAccessService<Product, int>, ProductDataAccess>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
