using API_APPS.Models;
using Microsoft.EntityFrameworkCore;

namespace API_APPS.Services
{
    public class CategoryDataAccess : IDbAccessService<Category, int>
    {
        eShoppingCodiContext context;

        public CategoryDataAccess(eShoppingCodiContext context)
        {
            this.context = context;
        }
        public async Task<Category> CreateAsync(Category entity)
        {
            try
            {
                var res = await context.Categories.AddAsync(entity);
                await context.SaveChangesAsync();
                return res.Entity;
            }
            catch (Exception ex )
            {

                throw ex;
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var record = await context.Categories.FindAsync(id);
            if (record == null)
            {
                throw new Exception("Record to delete is not found");
            }
                context.Categories.Remove(record);
                await context.SaveChangesAsync();   
                return true;
            
        }

        public async Task<IEnumerable<Category>> GetAsync()
        {
            var category =  await context.Categories.ToListAsync();
            if (category == null) throw new Exception("Record not found");
            return category;

        }

        public async Task<Category> GetAsync(int id)
        {
            var category = await context.Categories.FindAsync(id);
            if (category == null) throw new Exception("Record not found");
            return category;
        }

        public async Task<Category> UpdateAsync(int id, Category entity)
        {
            var category = await context.Categories.FindAsync(id);
            if (category == null)
            {
                throw new Exception("Record to be updated is not found");
            }
                category.CategoryName = entity.CategoryName;
                category.CategoryId = entity.CategoryId;
                category.BasePrice = entity.BasePrice;

                await context.SaveChangesAsync();

                return category;
            
        }
    }
}
