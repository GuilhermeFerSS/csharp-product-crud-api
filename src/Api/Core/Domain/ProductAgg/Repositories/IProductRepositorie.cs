using System.Collections.Generic;
using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities;

namespace csharp_product_crud_api.Api.Core.Domain.ProductAgg.Repositories
{
    public interface IProductRepositorie
    {
        void Create(Product product);
        ICollection<Product> SearchByName(string name);
        Product GetById(string id);
    }
}