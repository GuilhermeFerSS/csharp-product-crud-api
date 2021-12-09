using System.Net;
using Microsoft.AspNetCore.Mvc;
using csharp_product_crud_api.Api.Controllers.Contracts;

namespace csharp_product_crud_api.Api.Controllers.Extensions
{
    public static class ResponseExtensionMethod
    {
        public static IActionResult AsResponse(this object data, HttpStatusCode statusCode)
        {
            return new ObjectResult(new ResponseDto(data))
            {
                StatusCode = (int) statusCode
            };
        }
    }
}