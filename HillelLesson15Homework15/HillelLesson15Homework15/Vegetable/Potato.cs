using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelLesson15Homework15.Vegetable
{
    public class Potato : Product
    {
        private double _basePrice;
        public double Count { get; set; }

        public Potato(double price, double count) : base("Картопля", price)
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
