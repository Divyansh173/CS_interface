//using NorthWindApi.Controllers;
//using NorthWindApi.Models;
//namespace NorthWindApi.Services
//{
//    public class Assignment
//    {
//        NorthwindContext context;
//        CustomerDataAccess customer;
//        OrderDataAccess order;
//        OrderDetailDataAccess orderDetail;
//        ProductDataAccess product;

//        public Assignment(NorthwindContext context, CustomerDataAccess customer, OrderDataAccess order, OrderDetailDataAccess orderDetail, ProductDataAccess product)
//        {
//            this.context = context;
//            this.customer = customer;
//            this.order = order;
//            this.orderDetail = orderDetail;
//            this.product = product;
//        }

//      //  public async Task<IEnumerable<Customer>> data() 
//        //{
//        //    var customerdata = await customer.GetAsync();
//        //    var orderdata = await order.GetAsync();
//        //    var productdata = await product.GetAsync();
//        //    var orderDetaildata = await orderDetail.GetAsync();

//        //    var result = from cust in customerdata
//        //                 join ord in orderdata on cust.CustomerId equals ord.CustomerId
//        //                 join orddetail in orderDetaildata on ord.OrderId equals orddetail.OrderId
//        //                 join pro in productdata on orddetail.ProductId equals pro.ProductId
//        //                 where pro.ProductName == "Chai" || pro.ProductName == "Ikura" || pro.ProductName == "Pavlova"
//        //                 select new 
//        //                 {
//        //                     CustomerId = cust.CustomerId,
//        //                     CustyomerName = cust.ContactName
//        //                 };
//        //    return result;
//        //}
        
//    }
//}
