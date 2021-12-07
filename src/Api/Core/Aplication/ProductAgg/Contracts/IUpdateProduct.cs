namespace csharp_product_crud_api.Api.Controllers.Contracts
{
    public interface IUpdateProduct
    {
        string Name { get; }
        long Price { get; }
    }
}