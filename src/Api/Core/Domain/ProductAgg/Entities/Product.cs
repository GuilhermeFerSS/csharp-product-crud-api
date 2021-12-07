using System;

namespace csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities
{
    public class Product
    {
        private Product()
        {
        }

        public Product(string name, long price) : this()
        {
            ExternalId = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
            Status = "Active";
        }

        public long Id { get; private set; }
        public string ExternalId { get; private set; }
        public string Name { get; private set; }
        public long Price { get; private set; }
        public string Status { get; private set; }

        internal void Delete()
        {
            Status = "Inactive";
        }

    }
}