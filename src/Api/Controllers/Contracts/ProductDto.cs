using csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts;

namespace csharp_product_crud_api.Api.Controllers.Contracts
{
    public class ProductDto : IProduct
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
    }
}