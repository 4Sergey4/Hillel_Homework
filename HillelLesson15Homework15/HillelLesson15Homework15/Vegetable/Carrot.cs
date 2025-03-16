using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelLesson15Homework15.Vegetable
{
    public class Carrot : Product
    {
        private double _basePrice;

        public Carrot(double price) : base("Морква", price)
        {
            _basePrice = price;
        }

        public override double GetPrice()
        {
            return _basePrice;
        }
    }
}
