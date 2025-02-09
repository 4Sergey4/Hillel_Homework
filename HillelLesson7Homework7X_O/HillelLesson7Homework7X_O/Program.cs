using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string top1 = "1", top2 = "2", top3 = "3";
string mid1 = "4", mid2 = "5", mid3 = "6";
string bot1 = "7", bot2 = "8", bot3 = "9";
string player1 = "x";
string player2 = "o";
Console.WriteLine("Гра хрестики нулики. Починає грати 'х' (щоб зробити хід натисніть цифру на клавіатурі яка відповідає номеру на полі)");
Console.WriteLine($" {top1} | {top2} | {top3}\n ---------\n {mid1} | {mid2} | {mid3}\n ---------\n {bot1} | {bot2} | {bot3}");

while (true)
{
    player1 = Console.ReadLine();
    switch (player1)
    {
        case "1":
            top1 = "x";
            break;
        case "2":
            top2 = "x";
            break;
        case "3":
            top3 = "x";
            break;
        case "4":
            mid1 = "x";
            break;
        case "5":
            mid2 = "x";
            break;
        case "6":
            mid3 = "x";
            break;
        case "7":
            bot1 = "x";
            break;
        case "8":
            bot2 = "x";
            break;
        case "9":
            bot3 = "x";
            break;
    }
    Console.Clear();
    Console.WriteLine($" {top1} | {top2} | {top3}\n ---------\n {mid1} | {mid2} | {mid3}\n ---------\n {bot1} | {bot2} | {bot3}");
    Console.WriteLine("хід: о");
    if (top1 == "x" && top2 == "x" && top3 == "x" ||
       mid1 == "x" && mid2 == "x" && mid3 == "x" ||
       bot1 == "x" && bot2 == "x" && bot3 == "x" ||
       top1 == "x" && mid1 == "x" && bot1 == "x" ||
       top2 == "x" && mid2 == "x" && bot2 == "x" ||
       top3 == "x" && mid3 == "x" && bot3 == "x" ||
       top1 == "x" && mid2 == "x" && bot3 == "x" ||
       top3 == "x" && mid2 == "x" && bot1 == "x")
    {
        Console.WriteLine("Гравець 1 переміг!");
        return;
    }
    player2 = Console.ReadLine();
    switch (player2)
    {
        case "1":
            top1 = "o";
            break;
        case "2":
            top2 = "o";
            break;
        case "3":
            top3 = "o";
            break;
        case "4":
            mid1 = "o";
            break;
        case "5":
            mid2 = "o";
            break;
        case "6":
            mid3 = "o";
            break;
        case "7":
            bot1 = "o";
            break;
        case "8":
            bot2 = "o";
            break;
        case "9":
            bot3 = "o";
            break;
    }
    Console.Clear();
    Console.WriteLine($" {top1} | {top2} | {top3}\n ---------\n {mid1} | {mid2} | {mid3}\n ---------\n {bot1} | {bot2} | {bot3}");
    Console.WriteLine("хід: x");
    if (top1 == "o" && top2 == "o" && top3 == "o" ||
        mid1 == "o" && mid2 == "o" && mid3 == "o" ||
        bot1 == "o" && bot2 == "o" && bot3 == "o" ||
        top1 == "o" && mid1 == "o" && bot1 == "o" ||
        top2 == "o" && mid2 == "o" && bot2 == "o" ||
        top3 == "o" && mid3 == "o" && bot3 == "o" ||
        top1 == "o" && mid2 == "o" && bot3 == "o" ||
        top3 == "o" && mid2 == "o" && bot1 == "o")
    {
        Console.WriteLine("Гравець 2 переміг!");
        return;
    }
}