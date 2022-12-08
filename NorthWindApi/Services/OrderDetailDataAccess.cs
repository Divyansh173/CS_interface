//using NorthWindApi.models;
//using Microsoft.EntityFrameworkCore;
//namespace NorthWindApi.Services
//{
//    public class OrderDetailDataAccess
//    {
//        NorthwindContext context;

//        public OrderDetailDataAccess(NorthwindContext context)
//        {
//            this.context = context;
//        }

//        public async Task<IEnumerable<OrderDetail>> GetAsync()
//        {
//            var orderdetails = await context.OrderDetails.ToListAsync();
//            if (orderdetails == null) throw new Exception("Record not found");
//            return orderdetails;

//        }
//    }
//}
