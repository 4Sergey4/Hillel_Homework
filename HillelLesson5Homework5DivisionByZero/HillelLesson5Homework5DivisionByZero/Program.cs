using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int firstNumber;
int secondNumber;
int result;
while (true)
{
    Console.Write("Введіть перше число:");
    firstNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введіть друге число:");
    secondNumber = Convert.ToInt32(Console.ReadLine());

    try
    {
        result = firstNumber / secondNumber;
        Console.WriteLine($"{result}\n");
    }
    catch
    {
        Console.WriteLine("Помилка, на 0 ділити не можна\n");
    }
}