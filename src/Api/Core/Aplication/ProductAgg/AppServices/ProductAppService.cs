using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities;
using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Repositories;
using csharp_product_crud_api.Api.Controllers.Contracts;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Parsers;

namespace csharp_product_crud_api.Api.Core.Aplication.ProductAgg.AppServices
{
    public class ProductAppService
    {
        private readonly IProductRepositorie _repositorie;
        private readonly IParser<Product, IProduct> _parser;

        public ProductAppService(IProductRepositorie repositorie, IParser<Product, IProduct> parser)
        {
            _repositorie = repositorie;
            _parser = parser;
        }

        public IProduct Create(ICreateProduct createProduct)
        {
            var product = new Product(createProduct.Name, createProduct.Price);
            _repositorie.Create(product);
            return _parser.Parse(product);
        }

        public ICollection<IProduct> SearchByName(string name)
        {
            var products = _repositorie.SearchByName(name);
            return products.Select(product => _parser.Parse(product)).ToImmutableList();
        }
    }
}