using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities;
using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Repositories;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts;
using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Parsers;
using csharp_product_crud_api.Api.Core.Infrastructure.Shared;
using csharp_product_crud_api.Api.Core.Domain.Shared.Repositories;

namespace csharp_product_crud_api.Api.Core.Aplication.ProductAgg.AppServices
{
    public class ProductAppService
    {
        private readonly IProductRepositorie _repositorie;
        private readonly IProductParseFactory _parseFactory;
        private readonly IUnitOfWork _unitOfWork;

        public ProductAppService(IProductRepositorie repositorie, IProductParseFactory parseFactory, IUnitOfWork unitOfWork)
        {
            _repositorie = repositorie;
            _parseFactory = parseFactory;
            _unitOfWork = unitOfWork;
        }

        public IProduct Create(ICreateProduct createProduct)
        {
            var product = new Product(createProduct.Name, createProduct.Price);
            _repositorie.Create(product);
            _unitOfWork.SaveChanges();
            return _parseFactory.GetProductParse().Parse(product);
        }

        public ICollection<IProduct> SearchByName(string name)
        {
            var products = _repositorie.SearchByName(name);
            return products.Select(_parseFactory.GetProductReportParse().Parse).ToImmutableList();
        }
    }
}