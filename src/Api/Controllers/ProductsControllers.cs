using Microsoft.AspNetCore.Mvc;
using System.Linq;

using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.AppServices;
using csharp_product_crud_api.Api.Controllers.Contracts;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts;

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
            return Created(Request.Path, product);
        }

        [HttpGet]
        public IActionResult Query(string name)
        {
            var products = _appService.SearchByName(name);
            return Ok(products);
        }
    }
}