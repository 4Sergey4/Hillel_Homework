using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string name;
string surname;
while (true)
{
    Console.Write("Введіть ім'я: ");
    name = Console.ReadLine();
    Console.Write("Введіть прізвище: ");
    surname = Console.ReadLine();
    Console.WriteLine();
    if (name[0] == surname[0])
    {
        Console.WriteLine("Перша літера імені та прізвища однакові");
        Console.WriteLine($"Перша літера імені: {name[0]} \nПерша літера прізвища: {surname[0]}\n");
    }
    else
    {
        Console.WriteLine("Перша літера імені та прізвища різні");
        Console.WriteLine();
    }
}