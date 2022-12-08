using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_APPS1.Models;
using API_APPS1.Services;

namespace API_APPS1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        eShoppingCodiContext context;
        Search search;
 
        public SearchController(eShoppingCodiContext context, Search search)
        {
            this.context = context;
            this.search = search;
        }
        
        [HttpGet]
        public async Task<IActionResult> getdata(string ProductName, string CategoryName) 
        {
            //var result = (from product in context.Products
            //              join subcat in context.SubCategories on product.SubCategoryId equals subcat.SubCategoryId
            //              join cat in context.Categories on subcat.CategoryId equals cat.CategoryId
            //              where cat.CategoryName == CategoryName && product.ProductName == ProductName
            //              select product).ToList(); 
            //return Ok(result);
            var result = await search.getproduct(ProductName, CategoryName);
            return Ok(result);
        }
    }
}
