using MyShop.Services;
using MyShop.Models;
namespace MyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           ProductService productService = new ProductService();
            var result = productService.GetByFilter(new Models.ProductFilterModel());
            foreach (var item in result)
            {
                Console.WriteLine($"{item.Name} {item.Price}");
            }
        }
    }
}