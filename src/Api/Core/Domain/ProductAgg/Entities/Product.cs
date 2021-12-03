using System;

namespace csharp_product_crud_api.Api.Core.Domain.ProductAgg.Entities
{
    public class Product
    {
        private static long _id = 0;
        public Product(string name, long price)
        {
            Id = ++_id;
            ExternalId = Guid.NewGuid().ToString();
            Name = name;
            Price = price;
        }

        public long Id { get; }
        public string ExternalId { get; }
        public string Name { get; private set; }
        public long Price { get; private set; }
    }
}