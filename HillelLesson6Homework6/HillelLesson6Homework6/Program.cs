using System.Text;
using System.Text.RegularExpressions;

Console.OutputEncoding = Encoding.UTF8;
//1.Обчислення середнього заробітку
{
    double a, b, sum = 0;
    Console.Write("Введіть кількість працівників: ");
    double.TryParse(Console.ReadLine(), out a);
    for (int i = 1; i <= a; i++)
    {
        Console.Write($"Введіть зарплату {i} працівника: ");
        double.TryParse(Console.ReadLine(), out b);
        sum += b;
    }
    sum /= a;
    Console.WriteLine($"Середня зарплата {a}-х працівників: {sum}\n");
}

//2.Побудова графіку зірочками

{
    int a;
    string star = "*";
    Console.Write("Введіть число: ");
    a = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= a; i++)
    {
        Console.WriteLine(star);
        star += "*";
    }
    Console.WriteLine();
}
//4.Перевірка паролю
{
    string s;
    string patern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
    while (true)
    {
        Console.WriteLine("Введіть пароль(Пароль має містити хочаб одну велику літеру, цифру і спецсимвол): ");
        s = Console.ReadLine();
        if (Regex.IsMatch(s, patern))
        {
            Console.WriteLine($"Пароль прийнято, ваш пароль: {s}");
            Console.WriteLine();
            break;
        }
        else
        {
            Console.WriteLine("Некоректний введ паролю:");
        }
    }
}
//5.Генерація фібоначчівської послідовності
{
    int a, b, c, fib;
    Console.Write("Введіть кількість ітерацій послідовності Фібоначчі: ");
    fib = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введіть перше чісло: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введіть друге чісло: ");
    b = Convert.ToInt32(Console.ReadLine());
    for (int i = 0; i < fib; i++)
    {
        c = a + b;
        Console.Write($"{c}, ");
        a = b;
        b = c;
    }
    Console.WriteLine("\n");
}
//6.Калькулятор оплати праці за годину
{
    double a, b, sum;
    while (true)
    {
        Console.Write("Введіть кількість годин: ");
        double.TryParse(Console.ReadLine(), out a);
        Console.Write("Введіть зарплату за годину: ");
        double.TryParse(Console.ReadLine(), out b);
        sum = a * b;
        Console.WriteLine($"Зарплата за зміну: {sum}\n");
        break;
    }
}
//7.Генерація таблиці множення для конкретного числа
{
    int a, sum;
    Console.Write("Введіть цифру: ");
    a = Convert.ToInt32(Console.ReadLine());
    for (int i = 1; i <= 10; i++)
    {
        sum = a * i;
        Console.WriteLine($"{a} * {i} = {sum}");
    }
}