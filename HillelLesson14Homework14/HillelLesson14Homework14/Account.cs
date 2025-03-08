using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelLesson14Homework14
{
    internal class Account
    {
        private long _account;

        public string Name;
        public long Balance 
        { 
            get
            {
                return _account;
            }
            set
            {
                _account = value;
            }
        }

        public Account(string name, long balance)
        {
            Name = name;
            Balance = balance;
        }
        public void WriteMyInfo()
        {
            Console.WriteLine($"Ім'я: {Name}, Баланс: {Balance}$");
        }

        public long Withdrawal(long amount)
        {
            if (amount > Balance)
            {
                Console.WriteLine("Баланс власника не може бути менше нуля!");
                return 0;
            }
            Balance -= amount;
            return amount;
        }

        public long Deposit(long amount)
        {
            if (amount < 0)
            {
                return 0;
            }
            Balance += amount;
            return amount;
        }
    }
}
