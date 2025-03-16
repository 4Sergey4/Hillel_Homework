using HillelLesson15Homework15.Vegetable;
using System.Text;

namespace HillelLesson15Homework15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var products = new List<Product>
                {
                    new Carrot(15),
                    new Potato(20,4),
                    new Cucumber(14, 3),
                };

            VegetableShop shop = new VegetableShop();

            shop.AddProducts(products);
            
            shop.PrintProductsInfo();
        }
    }
}
