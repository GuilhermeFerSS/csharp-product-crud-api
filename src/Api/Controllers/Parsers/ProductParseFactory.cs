using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Parsers;
using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities;

namespace csharp_product_crud_api.Api.Controllers.Parsers
{
    public class ProductParseFactory : IProductParseFactory
    {
        public IParser<Product, IProduct> GetProductParse()
        {
            return new ProductParser();
        }

        public IParser<Product, IProduct> GetProductReportParse()
        {
            return new ProductReportParser();
        }
    }
}