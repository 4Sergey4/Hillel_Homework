using System.Text;

namespace HillelLesson14Homework14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Account BobAccount = new Account("Bob", 1000);
            Account JoeAccount = new Account("Joe", 1500);

            BobAccount.MyAccountInfo();
            JoeAccount.MyAccountInfo();
            Console.WriteLine();

            BobAccount.Deposit(500);
            BobAccount.MyAccountInfo();
            JoeAccount.Deposit(1000);
            JoeAccount.MyAccountInfo();
            Console.WriteLine();

            BobAccount.Withdraw(200);
            BobAccount.MyAccountInfo();
            JoeAccount.Withdraw(500);
            JoeAccount.MyAccountInfo();
            Console.WriteLine();

            BobAccount.Withdraw(2000);
            BobAccount.MyAccountInfo();
            JoeAccount.Withdraw(2500);
            JoeAccount.MyAccountInfo();
        }
    }
}
