using System.Text;

namespace HillelLesson12Homework12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int n;

            Console.Write("Введіть кількість ітерацій Фібоначчі: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"\n\tЧисла Фібоначчі:\n");

            for (int i = 0; i < n; i++)
            {
                Console.Write($"{Fibonacci(i)} ");
            }
        }

        static int Fibonacci(int n)
        {
            if( n < 2)
            {
                return n; 
            }
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

    }
}
