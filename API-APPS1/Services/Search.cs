using API_APPS1.Models;
using Microsoft.EntityFrameworkCore;

namespace API_APPS1.Services
{
    public class Search
    {
        eShoppingCodiContext context;

        public Search(eShoppingCodiContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Product>> getproduct(string ProductName, string CategoryName) 
        {
            var result = (from product in context.Products
                          join subcat in context.SubCategories on product.SubCategoryId equals subcat.SubCategoryId
                          join cat in context.Categories on subcat.CategoryId equals cat.CategoryId
                          where cat.CategoryName == CategoryName && product.ProductName == ProductName
                          select product).ToList();
            return result;
        }
    }
}
