//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using NorthWindApi.Services;

//namespace NorthWindApi.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class firstqueryController : ControllerBase
//    {
//        Assignment assignment;
//        CustomerDataAccess customer;
//        OrderDataAccess order;
//        OrderDetailDataAccess orderDetail;
//        ProductDataAccess product;
//        public firstqueryController(Assignment assignment, CustomerDataAccess customer, OrderDataAccess order, OrderDetailDataAccess orderDetail, ProductDataAccess product)
//        {
//            this.assignment = assignment;
//            this.customer = customer;
//            this.order = order;
//            this.orderDetail = orderDetail;
//            this.product = product;
//        }

//        [HttpGet]

//        public async Task<IActionResult> Get() 
//        {
//            //var result = await assignment.data();
//            var customerdata = await customer.GetAsync();
//            var orderdata = await order.GetAsync();
//            var productdata = await product.GetAsync();
//            var orderDetaildata = await orderDetail.GetAsync();

//            //var result = from cust in customerdata
//            //             join ord in orderdata on cust.CustomerId equals ord.CustomerId
//            var result = from ord in orderdata
//                         join orddetail in orderDetaildata on ord.OrderId equals orddetail.OrderId
//                         join pro in productdata on orddetail.ProductId equals pro.ProductId
//                         where pro.ProductName == "Chai" || pro.ProductName == "Ikura" || pro.ProductName == "Pavlova"
//                         orderby ord.CustomerId
//                         select new
//                         {
//                             CustomerId = ord.CustomerId
//                            // CustyomerName = cust.ContactName
//                         };;

//            return Ok(result);
//        }
//    }
//}
