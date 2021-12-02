namespace csharp_product_crud_api.Api.Core.Aplication.ProductAgg.Contracts
{
    public interface IProduct
    {
        long Id { get; }
        string Name { get; }
        string Price { get; }
    }
}