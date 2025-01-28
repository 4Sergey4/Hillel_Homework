using System.Text;

Console.OutputEncoding = Encoding.UTF8;
do 
{ 
    Console.Write("Введіть номер чи скорочення дня тижня:");
    string Day = Console.ReadLine();

    switch (Day)
    {
        case "1":
            Console.WriteLine("Пн = Понеділок\n");
            break;
        case "2":
            Console.WriteLine("Вт = Вівторок\n");
            break;
        case "3":
            Console.WriteLine("Ср = Середа\n");
            break;
        case "4":
            Console.WriteLine("Чт = Четверг\n");
            break;
        case "5":
            Console.WriteLine("Пт = П'ятниця\n");
            break;
        case "6":
            Console.WriteLine("Сб = Субота\n");
            break;
        case "7":
            Console.WriteLine("Нд = Неділя\n");
            break;

        case "Пн":
            Console.WriteLine("Понеділок 1-й день\n");
            break;
        case "Вт":
            Console.WriteLine("Вівторок 2-й день\n");
            break;
        case "Ср":
            Console.WriteLine("Середа 3-й день\n");
            break;
        case "Чт":
            Console.WriteLine("Четверг 4-й день\n");
            break;
        case "Пт":
            Console.WriteLine("П'ятниця 5-й день\n");
            break;
        case "Сб":
            Console.WriteLine("Субота 6-й день\n");
            break;
        case "Нд":
            Console.WriteLine("Неділя 7-й день\n");
            break;
        default:
            Console.WriteLine("У тижні сім днів\n");
            break;
    }
} while (true);