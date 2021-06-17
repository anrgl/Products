using Products.Repository;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            var products = ProductRepository.GenerateProducts(1000);
            ProductRepository.MakeJson(products, "products");
            var productsByPrice = ProductRepository.SplitByPrice(products.Values);
            foreach (var p in productsByPrice)
            {
                string fileName = p.Key.ToString();
                ProductRepository.MakeJson(p.Value, fileName);
            }
        }
    }
}
