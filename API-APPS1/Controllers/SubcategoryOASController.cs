using Microsoft.AspNetCore.Mvc;
using API_APPS1.Models;
using API_APPS1.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.AspNetCore.Mvc.Formatters;
using System.Net.Mime;
using Microsoft.EntityFrameworkCore;

namespace API_APPS1.Controllers
{
    [Route("api/[controller]")]
    [Consumes(MediaTypeNames.Application.Json)]
    [Produces(MediaTypeNames.Application.Json)]
    [ApiController]
    public class SubcategoryOASController : ControllerBase
    {
        IDbAccessService<Category, int> catdbAccess;
        IDbAccessService<Product, int> prodbAccess;
        IDbAccessService<SubCategory, int> subcatdbAccess;
        eShoppingCodiContext context;
        public SubcategoryOASController(IDbAccessService<Category, int> catdbAccess, eShoppingCodiContext context, IDbAccessService<Product, int> prodbAccess)
        {
            this.catdbAccess = catdbAccess;
            this.context = context;
            this.prodbAccess = prodbAccess;
        }

        [HttpGet("/getcategories")]
        public async Task<IEnumerable<Category>> Get()
        {
            var result = await catdbAccess.GetAsync();
            return result;
        }

        [HttpGet("/createcategory")]
        public async Task<Category> Post(Category category) 
        {
            var result = await catdbAccess.CreateAsync(category);
            return result;
        }

        [HttpGet("/getproduct")]

        public async Task<IEnumerable<Product>> Get(int id)
        {
                var data = await (from product in context.Products
                                  join subCategory in context.SubCategories on product.SubCategoryId equals subCategory.SubCategoryId
                                  where subCategory.CategoryId == id
                                  select product).ToListAsync();
                return data;
        }
    }
}
