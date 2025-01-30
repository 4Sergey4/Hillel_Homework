using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double d1;
while (true)
{
    Console.Write("Введіть число:");
    if (double.TryParse(Console.ReadLine(), out d1))
    {
        Console.WriteLine($"d1\n");
    }
    else
    {
        Console.WriteLine("Помилка, введіть число\n");
    }
}