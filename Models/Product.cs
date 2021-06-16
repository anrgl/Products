using System;

namespace Products.Models
{
    class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }

        public static Product Of(int id, string name)
        {
            Product product = new Product();
            product.ID = id;
            product.Name = name;
            product.Price = new Random().Next(1, 1001);
            return product;
        }

        public override string ToString()
        {
            return $"{ID};{Name};{Price}";
        }
    }
}