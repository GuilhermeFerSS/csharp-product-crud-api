using System;
using System.Net;
using System.Net.Mime;
using System.Threading.Tasks;
using csharp_product_crud_api.Api.Controllers.Contracts;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.AppServices;
using Microsoft.AspNetCore.Http;

namespace csharp_product_crud_api.Api
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        
        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }
    
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception exception)
            {
                var statusCode = exception switch
                {
                    NotFoundException => (int) HttpStatusCode.NotFound,
                    _ => (int) HttpStatusCode.InternalServerError
                };

                context.Response.StatusCode = statusCode;
                context.Response.ContentType = MediaTypeNames.Application.Json;
                context.Response.WriteAsJsonAsync(new ResponseDto(exception));
            }
        }
    }
}