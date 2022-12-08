//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using NorthWindApi.Services;

//namespace NorthWindApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class OrderDetailsController : ControllerBase
//    {
//        OrderDetailDataAccess orderdetails;

//        public OrderDetailsController(OrderDetailDataAccess orderdetails)
//        {
//            this.orderdetails = orderdetails;
//        }

//        [HttpGet]

//        public async Task<IActionResult> Get()
//        {
//            var output = await orderdetails.GetAsync();

//            return Ok(output);
//        }
//    }
//}
