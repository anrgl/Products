using System;

namespace Products.Models
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public static Product Of(int id)
        {
            Product product = new Product
            {
                Id = id,
                Name = $"Product #{id}",
                Price = new Random().Next(1, 1001)
            };
            return product;
        }

        public override string ToString()
        {
            return $"{Id};{Name};{Price}";
        }
    }
}