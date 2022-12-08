using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_APPS1.Services;
using API_APPS1.Models;

namespace API_APPS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IDbAccessService<Product, int> catService;
        IDbAccessService<SubCategory, int> subcat;
        static int value = 0;
        public ProductController(IDbAccessService<Product, int> catService, IDbAccessService<SubCategory, int> subcategory)
        {
            this.catService = catService;
            this.subcat = subcategory;
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
            var output = (await subcat.GetAsync()).Where(c => c.SubCategoryId == product.SubCategoryId).FirstOrDefault();
            if (output == null) return Conflict($"{product.SubCategoryId} does not exist");
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

        //[HttpGet("{no_of_records}")]
        //public async Task<IActionResult> getproduct(int id, int no_of_records) 
        //{
        //    var result = await catService.GetAsync();
        //    var data = (from pro in result
        //               where pro.SubCategoryId == id
        //               select pro).ToList().Skip(value);

        //    int val_1 = 0;
        //    List<Product> l1 = new List<Product>();
        //    foreach (var it in data)
        //    {
        //         if(val_1<no_of_records)
        //        {
        //            l1.Add(it);
        //            val_1++;
        //            value++;
        //        }

        //         else
        //        {
        //            break;
        //        }
        //    }

        //    return Ok(l1);  
        //}
    }
}
