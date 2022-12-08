// See https://aka.ms/new-console-template for more information
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;

Console.WriteLine("Consume the Rest Api");
Console.WriteLine("Press a key when Service Starts");

Console.ReadLine();
HttpClient client = new HttpClient();

var cats = await client.GetFromJsonAsync<List<Category>>("https://localhost:7270/divyansh/Category");

foreach (var item in cats) 
{
    Console.WriteLine($"{item.CategoryId} {item.CategoryName} {item.BasePrice}");
}
Console.ReadLine();

//Console.WriteLine("Post");
//var catNew = new Category()
//{
//    CategoryId = 1010,
//    CategoryName = "Shose",
//    BasePrice = 4444
//};

//var response = await client.PutAsJsonAsync<Category>($"https://localhost:7270/divyansh/Category{catNew.CategoryId}", catNew);
public partial class Category
{
    public Category()
    {
        SubCategories = new HashSet<SubCategory>();
    }

    public int CategoryId { get; set; }
    public string CategoryName { get; set; } = null!;
    public decimal BasePrice { get; set; }

    public virtual ICollection<SubCategory> SubCategories { get; set; }
}

public partial class SubCategory
{
    public SubCategory()
    {
        Products = new HashSet<Product>();
    }

    public int SubCategoryId { get; set; }
    public string SubCategoryName { get; set; } = null!;
    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;
    public virtual ICollection<Product> Products { get; set; }
}

public partial class Product
{
    public int ProductUniqueId { get; set; }
    public string ProductId { get; set; } = null!;
    public string ProductName { get; set; } = null!;
    public string Description { get; set; } = null!;
    public decimal Price { get; set; }
    public int SubCategoryId { get; set; }
    public int? ManufacturerId { get; set; }

    public virtual SubCategory SubCategory { get; set; } = null!;
}