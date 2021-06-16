using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Products.Models;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Product> products = GenerateProductsStore(1000);
            MakeJSON(products, "products.json");
        }

        private static void MakeJSON(Dictionary<int, Product> products, string fineName)
        {
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string jsonString = JsonSerializer.Serialize(products, options);
            File.WriteAllText(fineName, jsonString);
        }

        private static Dictionary<int, Product> GenerateProductsStore(int prodCount)
        {
            Dictionary<int, Product> products = new Dictionary<int, Product>(prodCount);
            for (int i = 1; i < prodCount + 1; i++)
            {
                products.Add(i, Product.Of(i, "Product #" + i));
            }
            return products;
        }
    }
}
