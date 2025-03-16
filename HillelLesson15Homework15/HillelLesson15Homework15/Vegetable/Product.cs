using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelLesson15Homework15.Vegetable
{
    public class Product
    {
        public double BasePrice { get; set; }
        public string Name { get; set; }

        public Product(string name, double price)
        {
            BasePrice = price;
            Name = name;
        }

        public virtual double GetPrice()
        {
            return BasePrice;
        }

        public virtual string GetName()
        {
            return $"{Name}, Ціна: {BasePrice} грн";
        }
    }
}
