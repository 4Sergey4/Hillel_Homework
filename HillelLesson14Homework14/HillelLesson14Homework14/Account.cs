using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HillelLesson14Homework14
{
    internal class Account
    {
        private long _joeBalance = 4500;
        private long _bobBalance = 55000;

        public string Name;
        public long JoeBalance 
        { 
            get
            {
                return _joeBalance;
            }
            set
            {
                _joeBalance = value;
            }
        }
        public long BobBalance
        {
            get
            {
                return _bobBalance;
            }
            set
            {
                _bobBalance = value;
            }
        }

        public Account(string name)
        {
            Name = name;
        }
        public void WriteMyInfo()
        {
            if(Name == "Joe")
            {
                Console.WriteLine($"Ім'я: {Name}, Баланс: {JoeBalance}$");
            }
            else if (Name == "Bob")
            {
                Console.WriteLine($"Ім'я: {Name}, Баланс: {BobBalance}$");
            }
        }

        public long Withdrawal(long amount)
        {
            if (Name == "Joe")
            {
                if (amount > JoeBalance)
                {
                    Console.WriteLine("Баланс власника не може бути менше нуля!");
                    return 0;
                }
                JoeBalance -= amount;
            }
            else if (Name == "Bob")
            {
                if (amount > BobBalance)
                {
                    Console.WriteLine("Баланс власника не може бути менше нуля!");
                    return 0;
                }
                BobBalance -= amount;
            }
            return amount;
        }

        public long Deposit(long amount)
        {
            if (Name == "Joe")
            {
                if(amount < 0)
                {
                    Console.WriteLine("Сума не може бути менше нуля!");
                    return 0;
                }
                JoeBalance += amount;
            }
            else if (Name == "Bob")
            {
                if (amount < 0)
                {
                    Console.WriteLine("Сума не може бути менше нуля!");
                    return 0;
                }
                BobBalance += amount;
            }
            return amount;
        }
    }
}
