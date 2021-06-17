using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Products.Models;

namespace Products.Repository
{
    class ProductRepository
    {
        public static void MakeJson(IDictionary<int, Product> products, string fileName)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(products, options);
            File.WriteAllText(fileName + ".json", jsonString);
        }

        public static void MakeJson(IList<Product> products, string fileName)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(products, options);
            File.WriteAllText(fileName + ".json", jsonString);
        }

        public static IDictionary<int, Product> GenerateProducts(int prodCount)
        {
            var products = new Dictionary<int, Product>(prodCount);
            for (int i = 1; i < prodCount + 1; i++)
            {
                products.Add(i, Product.Of(i));
            }
            return products;
        }

        public static IDictionary<int, IList<Product>> SplitByPrice(ICollection<Product> products)
        {
            var prodByPrice = new Dictionary<int, IList<Product>>();
            foreach (Product product in products)
            {
                int price = product.Price;
                int key = price / 101;
                if (!prodByPrice.ContainsKey(key))
                {
                    prodByPrice[key] = new List<Product>();
                }
                prodByPrice[key].Add(product);
            }
            return prodByPrice;
        }
    }
}