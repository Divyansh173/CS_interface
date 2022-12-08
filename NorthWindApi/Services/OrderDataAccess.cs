//using NorthWindApi.Models;
//using Microsoft.EntityFrameworkCore;
//namespace NorthWindApi.Services
//{
//    public class OrderDataAccess
//    {
//        NorthwindContext context;

//        public OrderDataAccess(NorthwindContext context)
//        {
//            this.context = context;
//        }

//        public async Task<IEnumerable<Order>> GetAsync()
//        {
//            var orders = await context.Orders.ToListAsync();
//            if (orders == null) throw new Exception("Record not found");
//            return orders;

//        }
//    }
//}
