namespace csharp_product_crud_api.Api.Core.Domain.Shared.Repositories
{
    public interface IUnitOfWork
    {
        void SaveChanges();
    }
}