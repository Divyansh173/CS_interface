using API_APPS1.CustomOps.CustomMiddlewares;
using Microsoft.EntityFrameworkCore;
using API_APPS1.Models;
using API_APPS1.Services;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<eShoppingCodiContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("AppConnection"));

});

builder.Services.AddControllers();//.AddJsonOptions(options =>
//{
//    options.JsonSerializerOptions.PropertyNamingPolicy = ;
//});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(20);
});


builder.Services.AddScoped<IDbAccessService<Category, int>, CategoryDataAccess>();
builder.Services.AddScoped<IDbAccessService<Product, int>, ProductDataAccess>();
builder.Services.AddScoped<IDbAccessService<SubCategory, int>, SubCategoryDataAccess>();
builder.Services.AddScoped<Search>();
//builder.Services.AddScoped<IDbAccessService<>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseSession();

app.UseAppExceptionHandler();

app.MapControllers();

app.Run();
