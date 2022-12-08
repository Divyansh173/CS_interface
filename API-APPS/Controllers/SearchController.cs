using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_APPS.Models;
using API_APPS.Services;

namespace API_APPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        IDbAccessService<Product, int> ProductService;
        IDbAccessService<Category, int> CategoryService;

        public SearchController(IDbAccessService<Product, int> productService, IDbAccessService<Category, int> categoryService)
        {
            ProductService = productService;
            CategoryService = categoryService;
        }

        //[HttpPost]

        //public async Task<IActionResult> Add(Category category, Product product) 
        //{
        //    var result = await CategoryService.CreateAsync(category);
        //    await ProductService.CreateAsync(product);
        //    return Ok(result);
        //}

        
    }
}
