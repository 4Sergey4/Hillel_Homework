using System.Text;

Console.OutputEncoding = Encoding.UTF8;

int i = 1;

StringBuilder sbb = new StringBuilder();

Console.WriteLine("Введіть заголовок, дату і опис події (щоб вийти натисніть q): ");

while (true)
{
   
    string user = Console.ReadLine();
    if (user == "q")
    {
        break;
    }
    sbb.Append($"Подія {i++}: ");
    sbb.AppendLine(user);
   
}
Console.WriteLine(sbb.ToString());