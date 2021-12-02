using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities;
using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Repositories;

namespace csharp_product_crud_api.Api.Core.Infrastructure.ProductAgg.Repositories
{
    public class ProductRepositorie : IProductRepositorie
    {
        private static List<Product> _product = new List<Product>();

        public void Create(Product product)
        {
            _product.Add(product);
        }

        public ICollection<Product> SearchByName(string name)
        {
            return _product.ToImmutableList();
            // return _product.Where(product => product.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
            //     .ToImmutableList();
        }
    }
}