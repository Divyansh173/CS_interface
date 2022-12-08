using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace API_APPS1.CustomOps.CustomMiddlewares
{
    internal class ErrorDetails 
    {
        public int StatusCode { get; set; }
        public string? ErrorMessage { get; set; }
    }
    public class ExceptionMiddleware
    {
        RequestDelegate? _next;

        public ExceptionMiddleware(RequestDelegate? next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context) 
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.StatusCode = 500;
                string errorMessage = ex.Message;

                ErrorDetails errorDetails = new ErrorDetails()
                {
                    StatusCode = context.Response.StatusCode,
                    ErrorMessage = errorMessage
                };

                await context.Response.WriteAsJsonAsync(errorDetails);
            }
        }
    }

    public static class ErrorMiddlewareExtension 
    {
        public static void UseAppExceptionHandler(this IApplicationBuilder builder) 
        {
            builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
