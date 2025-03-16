using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelLesson15Homework15.Vegetable
{
    public class Cucumber : Product
    {
        private double _basePrice;
        public double Count { get; set; }

        public Cucumber(double price, double count) : base("Огірок", price)
        {
            _basePrice = price;
            Count = count;
        }

        public override double GetPrice()
        {
            return _basePrice * Count;
        }
        public override string GetName()
        {
            return $"{Name}, Ціна: {BasePrice}, Кількість: {Count}, Повна ціна: {GetPrice()} грн";
        }
    }
}
