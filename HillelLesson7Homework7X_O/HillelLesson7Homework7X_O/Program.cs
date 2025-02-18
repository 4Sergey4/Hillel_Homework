using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string[,] tabl = new string[3, 3]
{
    {"1", "2", "3"},
    {"4", "5", "6"},
    {"7", "8", "9"}
};
string player1 = "x";
string player2 = "o";
Console.WriteLine("Гра хрестики нулики. Починає грати 'х' (щоб зробити хід натисніть цифру на клавіатурі яка відповідає номеру на полі)\n");
for (int i = 0; i < tabl.GetLength(0); i++)
{
    for (int j = 0; j < tabl.GetLength(1); j++)
    {
        Console.Write($"| {tabl[i, j]} |");

    }
    Console.WriteLine();
    Console.WriteLine("---------------");
}

while (true)
{
    player1 = Console.ReadLine();
    switch (player1)
    {
        case "1":
            tabl[0, 0] = "X";
            break;
        case "2":
            tabl[0, 1] = "X";
            break;
        case "3":
            tabl[0, 2] = "X";
            break;
        case "4":
            tabl[1, 0] = "X";
            break;
        case "5":
            tabl[1, 1] = "X";
            break;
        case "6":
            tabl[1, 2] = "X";
            break;
        case "7":
            tabl[2, 0] = "X";
            break;
        case "8":
            tabl[2, 1] = "X";
            break;
        case "9":
            tabl[2, 2] = "X";
            break;
    }
    Console.Clear();
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            Console.Write($"| {tabl[i, j]} |");

        }
        Console.WriteLine();
        Console.WriteLine("---------------");
    }
    Console.WriteLine("Хід o");
    if (tabl[0, 0] == "X" && tabl[0, 1] == "X" && tabl[0, 2] == "X" ||
        tabl[1, 0] == "X" && tabl[1, 1] == "X" && tabl[1, 2] == "X" ||
        tabl[2, 0] == "X" && tabl[2, 1] == "X" && tabl[2, 2] == "X" ||
        tabl[0, 0] == "X" && tabl[1, 0] == "X" && tabl[2, 0] == "X" ||
        tabl[0, 1] == "X" && tabl[1, 1] == "X" && tabl[2, 1] == "X" ||
        tabl[0, 2] == "X" && tabl[1, 2] == "X" && tabl[2, 2] == "X" ||
        tabl[0, 0] == "X" && tabl[1, 1] == "X" && tabl[2, 2] == "X" ||
        tabl[0, 2] == "X" && tabl[1, 1] == "X" && tabl[2, 0] == "X")
    {
        Console.WriteLine("Гравець 1 переміг!");
        return;
    }
    else
    {
        Console.WriteLine("nichiya");
    }

    player2 = Console.ReadLine();
    switch (player2)
    {
        case "1":
            tabl[0, 0] = "O";
            break;
        case "2":
            tabl[0, 1] = "O";
            break;
        case "3":
            tabl[0, 2] = "O";
            break;
        case "4":
            tabl[1, 0] = "O";
            break;
        case "5":
            tabl[1, 1] = "O";
            break;
        case "6":
            tabl[1, 2] = "O";
            break;
        case "7":
            tabl[2, 0] = "O";
            break;
        case "8":
            tabl[2, 1] = "O";
            break;
        case "9":
            tabl[2, 2] = "O";
            break;
    }
    Console.Clear();
    for (int i = 0; i < tabl.GetLength(0); i++)
    {
        for (int j = 0; j < tabl.GetLength(1); j++)
        {
            Console.Write($"| {tabl[i, j]} |");

        }
        Console.WriteLine();
        Console.WriteLine("---------------");
    }
    Console.WriteLine("Хід x");
    if (tabl[0, 0] == "O" && tabl[0, 1] == "O" && tabl[0, 2] == "O" ||
        tabl[1, 0] == "O" && tabl[1, 1] == "O" && tabl[1, 2] == "O" ||
        tabl[2, 0] == "O" && tabl[2, 1] == "O" && tabl[2, 2] == "O" ||
        tabl[0, 0] == "O" && tabl[1, 0] == "O" && tabl[2, 0] == "O" ||
        tabl[0, 1] == "O" && tabl[1, 1] == "O" && tabl[2, 1] == "O" ||
        tabl[0, 2] == "O" && tabl[1, 2] == "O" && tabl[2, 2] == "O" ||
        tabl[0, 0] == "O" && tabl[1, 1] == "O" && tabl[2, 2] == "O" ||
        tabl[0, 2] == "O" && tabl[1, 1] == "O" && tabl[2, 0] == "O")
    {
        Console.WriteLine("Гравець 2 переміг!");
        return;
    }
    else
    {
        {
            Console.WriteLine("nichiya");
        }
    }
}