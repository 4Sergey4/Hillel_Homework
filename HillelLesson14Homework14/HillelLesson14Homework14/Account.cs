using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelLesson14Homework14
{
    internal class Account
    {
        private long _balance;
        private string Name;

        public Account(string name, long initialBalance)
        {
            Name = name;
            if (initialBalance >= 0)
            {
                _balance = initialBalance;
            }
            else
            {
                initialBalance = 0;
            }
            
        }

        public void Deposit(long amount)
        {
            if (amount > 0)
            {
                _balance += amount;
                Console.WriteLine($"{amount} додано на рахунок {Name}");
            }
            else
            {
                Console.WriteLine("Сума повинна бути більше 0");
            }
        }

        public bool Withdraw(long amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"{amount} знято з рахунку");
                return true;
            }
            else
            {
                Console.WriteLine("Недостатньо коштів на рахунку");
                return false;
            }
        }
        public void MyAccountInfo()
        {
            Console.WriteLine($"На рахунку {Name} {_balance} $");
        }
    }
}
