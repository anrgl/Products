using Products.Repository;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileName = "products";
            var products = ProductRepository.GenerateProducts(1000);
            ProductRepository.MakeJson(products, fileName);
            var prods = ProductRepository.ReadJson(fileName);
            var productsByPrice = ProductRepository.SplitByPrice(prods.Values);
            foreach (var p in productsByPrice)
            {
                ProductRepository.MakeJson(p.Value, p.Key.ToString());
            }
        }
    }
}
