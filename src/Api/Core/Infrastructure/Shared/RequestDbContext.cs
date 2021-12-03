using csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities;
using Microsoft.EntityFrameworkCore;

namespace csharp_product_crud_api.Api.Core.Infrastructure.Shared
{
    public class RequestDbContext : DbContext
    {
        public RequestDbContext(DbContextOptions<RequestDbContext> options) : base(options)
        {
        }
        
        public DbSet<Product> Products { get; set; }
    }
}