using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities;
using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Repositories;
using csharp_product_crud_api.Api.Core.Infrastructure.Shared;

namespace csharp_product_crud_api.Api.Core.Infrastructure.ProductAgg.Repositories
{
    public class ProductRepositorie : IProductRepositorie
    {
        private readonly RequestDbContext _context;

        public ProductRepositorie(RequestDbContext context)
        {
            _context = context;
        }

        public void Create(Product product)
        {
            _context.Set<Product>().Add(product);
        }

        public ICollection<Product> SearchByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                return _context.Set<Product>().ToImmutableList();
            }
            return _context.Set<Product>()
                .Where(product => product.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                .ToImmutableList();
        }
    }
}