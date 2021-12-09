using System;
using Microsoft.AspNetCore.Mvc;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts;
using csharp_product_crud_api.Api.Controllers.Extensions;

namespace csharp_product_crud_api.Api.Controllers.Contracts
{

    public class ResponseDto
    {

        public ResponseDto(object data)
        {
            Data = data;
        }

        public ResponseDto(Exception exception)
        {
            Error = new ErrorDto(exception);
        }

        public object Data { get; }

        public ErrorDto Error { get; }

        public class ErrorDto
        {
            
            public ErrorDto(Exception exception)
            {
                Message = exception.Message;
                Data = exception.Data;
                StackTrace = exception.StackTrace;
            }
            
            public string Message { get; }
            public object Data { get; }
            public string StackTrace { get; }
        }
    }
}