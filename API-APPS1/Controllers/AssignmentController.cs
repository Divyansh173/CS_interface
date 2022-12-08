using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using API_APPS1.Services;
using API_APPS1.Models;
using API_APPS1.CustomSessionExtension;

namespace API_APPS1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController : Controller
    {
        IDbAccessService<Product, int> productService;
        IDbAccessService<SubCategory, int> subCategoryService;

        public AssignmentController(IDbAccessService<Product, int> productService,IDbAccessService<SubCategory, int> subcatservice)
        {
            this.productService = productService;
            this.subCategoryService = subcatservice;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string name, int no_of_records)
        {
            int val = 0;
            IEnumerable<Product> data2;
            if (HttpContext.Session.GetObject<int>("key") != 0) 
            {
                val = HttpContext.Session.GetObject<int>("key");
            }
            if (name != HttpContext.Session.GetObject<String>("name"))
            {
                val = 0;
                var result = await productService.GetAsync();
                var data = await subCategoryService.GetAsync();
                data2 = (from pro in result
                             join subcat in data on pro.SubCategoryId equals subcat.SubCategoryId
                             where subcat.SubCategoryName == name
                             select pro).Skip(val).Take(no_of_records);
            }
            val += no_of_records;
            HttpContext.Session.SetObject<int>("key",val);
            HttpContext.Session.SetObject<String>("name", name);
            return Ok(data2);

        }
    }
}
