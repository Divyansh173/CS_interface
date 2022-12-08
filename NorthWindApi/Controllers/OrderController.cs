//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using NorthWindApi.Services;

//namespace NorthWindApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class OrderController : ControllerBase
//    {
//        OrderDataAccess orders;

//        public OrderController(OrderDataAccess orders)
//        {
//            this.orders = orders;
//        }

//        [HttpGet]

//        public async Task<IActionResult> Get()
//        {
//            var output = await orders.GetAsync();

//            return Ok(output);
//        }
//    }
//}
