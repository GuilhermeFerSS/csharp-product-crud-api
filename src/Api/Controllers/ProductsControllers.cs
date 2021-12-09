using System.Net;
using Microsoft.AspNetCore.Mvc;

using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.AppServices;
using csharp_product_crud_api.Api.Controllers.Contracts;
using csharp_product_crud_api.Api.Controllers.Extensions;

namespace csharp_product_crud_api.Api.Controllers
{
    [ApiController]
    [Route("/products")]
    public class ProductsControllers : ControllerBase
    {
        private readonly ProductAppService _appService;

        public ProductsControllers(ProductAppService appService)
        {
            _appService = appService;
        }

        [HttpPost]
        public IActionResult Add(CreateProductDto createProductDto)
        {
            var product = _appService.Create(createProductDto);
            return product.AsResponse(HttpStatusCode.Created);
        }

        [HttpGet]
        public IActionResult Query(string name)
        {
            var products = _appService.SearchByName(name);
            return products.AsResponse(HttpStatusCode.OK);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var product = _appService.GetById(id);
            return product.AsResponse(HttpStatusCode.OK);
        }

        [HttpPut("{id}")]
        public IActionResult Update(string id, UpdateProductDto updateProduct)
        {
            var product = _appService.Update(id, updateProduct);
            return product.AsResponse(HttpStatusCode.OK);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _appService.Delete(id);
            return NoContent();
        }
    }
}