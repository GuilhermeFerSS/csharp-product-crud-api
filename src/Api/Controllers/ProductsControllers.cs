using Microsoft.AspNetCore.Mvc;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.AppServices;
using csharp_product_crud_api.Api.Controllers.Contracts;
using System.Linq;

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

        [HttpGet("{id}")]
        public IActionResult GetById(long id)
        {
            var products = _appService.SearchByName(null);
            return Ok(products.First(x => x.Id == id));
        }
    }
}