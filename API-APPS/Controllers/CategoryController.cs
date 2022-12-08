using Microsoft.AspNetCore.Http;
using API_APPS.Models;
using API_APPS.Services;
using Microsoft.AspNetCore.Mvc;

namespace API_APPS.Controllers
{
    [Route("divyansh/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        IDbAccessService<Category, int> catService;

        public CategoryController(IDbAccessService<Category, int> catService)
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
        public async Task<IActionResult> create(Category category) 
        {
            //Category category = new Category(){ CategoryId = 1000,CategoryName = "kapdelelo", BasePrice= 1000 };
            var result = await catService.CreateAsync(category);
            return Ok(result);

        }

        [HttpPut]

        public async Task<IActionResult> update(int id, Category category) 
        {
            var result = await catService.UpdateAsync(id, category);
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
