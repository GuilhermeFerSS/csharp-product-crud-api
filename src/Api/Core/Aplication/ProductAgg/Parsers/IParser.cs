using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts;
using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities;

namespace csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Parsers
{
    public interface IParser<TFrom, TTo>
    {
        TTo Parse(TFrom from);
    }

    public interface IProductParseFactory
    {
        IParser<Product, IProduct> GetProductParse();
        IParser<Product, IProduct> GetProductReportParse();
    }
}