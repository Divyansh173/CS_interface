using Microsoft.AspNetCore.Mvc;
using NorthWindApi.Models;
//using NorthWindApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Caching.Memory;

namespace NorthWindApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryCacheController : ControllerBase
    {
        IMemoryCache memoryCache;
       // CustomersEmployeesShipper customersEmployeesShipper;
        private string cacheKey = "shippers";
        NorthwindContext context;

        public CategoryCacheController(IMemoryCache memoryCache,NorthwindContext context)
        {
           // this.customersEmployeesShipper = customersEmployeesShipper;
            this.memoryCache = memoryCache;
            this.context = context;
        }

        [HttpGet]
        public async Task<ResponseObject> GetAsync() 
        {
            ResponseObject responseObject = new ResponseObject();
            List<CustomersEmployeesShipper> shippers = null;
            try
            {
                var isDataAvailableInCache = memoryCache.TryGetValue(cacheKey, out shippers);
                if (!isDataAvailableInCache)
                {
                    shippers = (context.CustomersEmployeesShippers).ToList();
                    responseObject.CustomersEmployeesShippers = shippers;
                    responseObject.Message = "Data is received from database";

                    var memoryCacheOptions = new MemoryCacheEntryOptions().SetSlidingExpiration(TimeSpan.FromSeconds(30)).SetAbsoluteExpiration(TimeSpan.FromMinutes(1));
                    memoryCache.Set(cacheKey, shippers, memoryCacheOptions);
                }
                else 
                {
                    responseObject.CustomersEmployeesShippers = shippers;
                    responseObject.Message = "Data is received from Cache";
                }
                return responseObject;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
