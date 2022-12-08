//using NorthWindApi.models;
//using Microsoft.EntityFrameworkCore;
//namespace NorthWindApi.Services
//{
//    public class ProductDataAccess
//    {
//        NorthwindContext context;

//        public ProductDataAccess(NorthwindContext context)
//        {
//            this.context = context;
//        }

//        public async Task<IEnumerable<Product>> GetAsync()
//        {
//            var product = await context.Products.ToListAsync();
//            if (product == null) throw new Exception("Record not found");
//            return product;

//        }
//    }
//}
