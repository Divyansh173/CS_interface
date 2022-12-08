using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_APPS.Services;
using API_APPS.Models;

namespace API_APPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IDbAccessService<Product, int> catService;

        public ProductController(IDbAccessService<Product, int> catService)
        {
            this.catService = catService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await catService.GetAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]

        public async Task<IActionResult> Get1(int id)
        {
            var result = await catService.GetAsync(id);
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> create(Product product)
        {
            //Category category = new Category(){ CategoryId = 1000,CategoryName = "kapdelelo", BasePrice= 1000 };
            var result = await catService.CreateAsync(product);
            return Ok(result);

        }

        [HttpPut]

        public async Task<IActionResult> update(int id, Product product)
        {
            var result = await catService.UpdateAsync(id, product);
            return Ok(result);
        }

        [HttpDelete]

        public async Task<IActionResult> delete(int id)
        {
            var result = await catService.DeleteAsync(id);
            return Ok(result);
        }
    }
}
