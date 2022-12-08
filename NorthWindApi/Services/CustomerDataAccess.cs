//using NorthWindApi.Models;
//using Microsoft.EntityFrameworkCore;

//namespace NorthWindApi.Services
//{
//    public class CustomerDataAccess
//    {
//        NorthwindContext context;

//        public CustomerDataAccess(NorthwindContext context)
//        {
//            this.context = context;
//        }

//        public async Task<IEnumerable<Customer>> GetAsync()
//        {
//            var customers = await context.Customers.ToListAsync();
//            if (customers == null) throw new Exception("Record not found");
//            return customers;

//        }
//    }
//}
