
using System.Text;

Console.OutputEncoding = Encoding.UTF8;

//Пункт 1 та 2

{
    int[] rand = new int[10];
    Random rnd = new Random();
    int sum = 0;
    for (int i = 0; i < rand.Length; i++)
    {
        rand[i] = rnd.Next(-10, 10);
        Console.WriteLine($"Massive so vsemi indeksami {i}: {rand[i]}");
    }
    Console.WriteLine("");
    for (int i = 0; i < rand.Length; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine($"Parniy indeks {i}: {rand[i]}");
            sum += rand[i];
        }
    }
    if (sum > 0)
    {
        Console.WriteLine($"summa: {sum}");
    }
    else
    {
        Console.WriteLine($"Summa otricatelna: {sum}");
    }
    Console.WriteLine();
}

// Пункт 3. Таблиця множення

{
    int[,] tabl = new int[9, 9];
    Console.Write("Таблиця множення: \n");
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            tabl[i, j] = (i + 1) * (j + 1);
            Console.Write($"{i + 1} * {j + 1} = {tabl[i, j]} \t");
        }
        Console.WriteLine();
    }
}

//Пункт 4. Мінімальне та максимальне значення в масиві + індекси

{
    int[,] tabl = new int[5, 5];
    int a = 0, b = 0, a1 = 0, b1 = 0;
    Random rnd = new Random();
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            tabl[i, j] = rnd.Next(100);
            Console.Write($"{tabl[i, j]} \t");
        }
        Console.WriteLine();
    }
    int minValue = tabl[0, 0];
    int maxValue = tabl[0, 0];

    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            if (tabl[i, j] < minValue)
            {
                minValue = tabl[i, j];
                a = i;
                b = j;
            }

            if (tabl[i, j] > maxValue)
            {
                maxValue = tabl[i, j];
                a1 = i;
                b1 = j;
            }
        }
    }
    Console.WriteLine($"Min value[{a},{b}]: {minValue}");
    Console.WriteLine($"Max value[{a1},{b1}]: {maxValue}");
}
//Пункт 5. Калькулятор днів тижня

{
    int n;
    while (true)
    {
        Console.WriteLine("Введіть число");
        n = Convert.ToInt32(Console.ReadLine());

        dayOfWeek startWeek = dayOfWeek.Monday;

        dayOfWeek resault = (dayOfWeek)((int)(startWeek + n - 1) % 7);
        Console.WriteLine(resault);

    }
}
enum dayOfWeek
{
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
}
