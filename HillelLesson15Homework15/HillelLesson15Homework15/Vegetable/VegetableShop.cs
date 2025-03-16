using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelLesson15Homework15.Vegetable
{
    public class VegetableShop
    {
        private List<Product> products;

        public VegetableShop()
        {
            products = new List<Product>();
        }

        public void AddProducts(List<Product> product)
        {
            products.AddRange(product);
        }
        public void PrintProductsInfo()
        {
            if (products.Count == 0)
            {
                Console.WriteLine("Магазин порожній");
            }
            else
            {
                double totalPrice = 0;
                foreach (var product in products)
                {
                    Console.WriteLine(product.GetName());
                    totalPrice += product.GetPrice();
                }
                Console.WriteLine($"Загальна вартість: {totalPrice}");
            }
        }
    }
}
