namespace csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts
{
    public interface ICreateProduct
    {
        string Name { get; }
        long Price { get; }
    }
}