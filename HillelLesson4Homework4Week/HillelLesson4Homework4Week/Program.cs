using System.Text;

Console.OutputEncoding = Encoding.UTF8;
while (true) 
{ 
    Console.Write("Введіть номер дня тижня:");
    int Day = Convert.ToInt32(Console.ReadLine());

    switch (Day)
    {
        case 1:
            Console.WriteLine("Пн = Понеділок\n");
            break;
        case 2:
            Console.WriteLine("Вт = Вівторок\n");
            break;
        case 3:
            Console.WriteLine("Ср = Середа\n");
            break;
        case 4:
            Console.WriteLine("Чт = Четверг\n");
            break;
        case 5:
            Console.WriteLine("Пт = П'ятниця\n");
            break;
        case 6:
            Console.WriteLine("Сб = Субота\n");
            break;
        case 7:
            Console.WriteLine("Нд = Неділя\n");
            break;
        default:
            Console.WriteLine("У тижні сім днів\n");
            break;
    }
} 