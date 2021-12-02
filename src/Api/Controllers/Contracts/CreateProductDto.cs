using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts;

namespace csharp_product_crud_api.Api.Controllers.Contracts
{
    public class CreateProductDto : ICreateProduct
    {
        public string Name { get; set; }
        public long Price { get; set; }
    }
}