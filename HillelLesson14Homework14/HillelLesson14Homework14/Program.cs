using System.Text;

namespace HillelLesson14Homework14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Account joe = new Account("Joe", 4500);
            Account bob = new Account("Bob", 55000);

            while (true)
            {
                joe.WriteMyInfo();
                bob.WriteMyInfo();
                Console.Write("Ведіть суму: ");
                string input = Console.ReadLine();
                if (input == "") break;
                if (long.TryParse(input, out long amount))
                {
                    Console.Write("Оберіть власника рахунку: ");
                    string owner = Console.ReadLine();
                    if (owner == "Joe")
                    {
                        Console.Write("Оберіть операцю(-,+): ");
                        string operation = Console.ReadLine();
                        if (operation == "-")
                        {
                            joe.Withdrawal(amount);
                        }
                        else if (operation == "+")
                        {
                            joe.Deposit(amount);
                        }
                    }
                    else if (owner == "Bob")
                    {
                        Console.WriteLine("Оберіть операцю(-,+): ");
                        string operation = Console.ReadLine();
                        if (operation == "-")
                        {
                            bob.Withdrawal(amount);
                        }
                        else if (operation == "+")
                        {
                            bob.Deposit(amount);
                        }
                    }
                    Console.WriteLine("Для завершення натисніть Enter");
                }

            }
        }
    }
}
