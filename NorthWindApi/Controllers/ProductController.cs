//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using NorthWindApi.models;
//using NorthWindApi.Services;

//namespace NorthWindApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class ProductController : ControllerBase
//    {
//        ProductDataAccess products;

//        public ProductController(ProductDataAccess products)
//        {
//            this.products = products;
//        }

//        [HttpGet]

//        public async Task<IActionResult> Get() 
//        {
//            var output = await products.GetAsync();

//            return Ok(output);
//        }
//    }
//}
