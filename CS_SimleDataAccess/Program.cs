using CS_SimleDataAccess.Models;
using CS_SimleDataAccess.DataAccess;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
try
{
    CategoryDbAccess category = new CategoryDbAccess();
    IEnumerable<Category> result = category.GetRecords();
    foreach (var cat in result) 
    {
        Console.WriteLine($"{cat.CategoryName}  {cat.CategoryId}  {cat.BasePrice}");
    }
    IDbAccess<Product, int> product = new ProductDbAccess();
    IEnumerable<Product> result1 = product.GetAll();
    Console.WriteLine("HEllo");
    foreach (var cat in result1)
    {
        Console.WriteLine($"{cat.ProductUniqueId}  {cat.ProductName}  {cat.Description}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}