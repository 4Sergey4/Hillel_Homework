﻿using System.Text;

Console.OutputEncoding = Encoding.UTF8;

// 1.Другий найбільший елемент масиву
{
    Random random = new Random();
    int[] maxOne = new int[10];

    for (int i = 0; i < maxOne.Length; i++)
    {
        maxOne[i] = random.Next(1, 100);
        Console.Write($"{maxOne[i]} ");
    }
    Console.WriteLine();

    int maxValue = maxOne.Max();
    Console.WriteLine($"\nМаксимальное значение: {maxValue}\n");

    int maxsecondValue = 0;
    foreach (int num in maxOne)
    {
        if (num > maxValue)
        {
            maxsecondValue = maxValue;
            maxValue = num;
        }
        else if (num > maxsecondValue && num != maxValue)
        {
            maxsecondValue = num;
        }
        Console.Write($"{num} ");
    }
    Console.WriteLine($"\n\nДруге максимальне значення: {maxsecondValue}");
}
Console.WriteLine("\n");

//2. Сортування двомірного масиву
{
    Random random = new Random();
    int[,] matrix = new int[3, 3];
    int[] tabl = new int[9];
    int a = 0;
    int[] sum = [5, 4, 3, 2, 1];

    Console.WriteLine("Матриця: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 100);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            tabl[a++] = matrix[i, j];
        }
    }
    Console.WriteLine();
    Array.Sort(tabl);

    a = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = tabl[a++];
        }
    }

    Console.WriteLine("Відсортована матриця: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("\n");

//3. Видалення елементу масиву за індексом
{
    int[] mass = new int[10];
    int index;
    int[] newMass = new int[mass.Length - 1];
    mass = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
    Console.Write("Масив: ");
    foreach (int i in mass)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine($"\n");
    Console.Write("Введіть індекс який хочете видалити від 0 до 9: ");
    while (int.TryParse(Console.ReadLine(), out index))
    {
        if (index < 0 || index >= mass.Length)
        {
            Console.Write("\nІндекс за межою масива(від 0 до 9): ");
        }
        else
        {
            break;
        }
    }

    for (int i = 0; i < index; i++)
    {
        newMass[i] = mass[i];
    }

    for (int i = index + 1; i < mass.Length; i++)
    {
        newMass[i - 1] = mass[i];
    }
    mass = newMass;
    Console.WriteLine();
    Console.Write("Масив після видалення елементу: ");
    foreach (int i in mass)
    {
        Console.Write($"{i} ");
    }
}
Console.WriteLine("\n");

//4.
{
    Random random = new Random();
    int[,] matrix = new int[3, 3];
    int sumLTR = 0, sumRTL = 0, sumAll;

    Console.WriteLine("Матріця: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(1, 100);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }

    int row = matrix.GetLength(0);
    for (int i = 0; i < row; i++)
    {
        sumLTR += matrix[i, i];
        sumRTL += matrix[i, row - i - 1];
    }
    Console.WriteLine();

    sumAll = sumLTR + sumRTL;
    Console.WriteLine($"Сума з ліва на право: {sumLTR}");
    Console.WriteLine($"Сума з права на ліво: {sumRTL}");
    Console.WriteLine($"Сума всіх елементів діагоналей: {sumAll}");
}
