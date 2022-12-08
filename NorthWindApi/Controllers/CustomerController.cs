//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using NorthWindApi.Services;

//namespace NorthWindApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class CustomerController : ControllerBase
//    {
//        CustomerDataAccess customers;

//        public CustomerController(CustomerDataAccess customers)
//        {
//            this.customers = customers;
//        }

//        [HttpGet]

//        public async Task<IActionResult> Get()
//        {
//            var output = await customers.GetAsync();

//            return Ok(output);
//        }
//    }
//}
