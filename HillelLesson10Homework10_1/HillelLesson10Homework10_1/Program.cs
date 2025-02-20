using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string fullName;
while (true)
{
    Console.Write("Введіть ім'я та прізвище: ");
    fullName = Console.ReadLine();

    string[] words = fullName.Split(' ');

    if (words.Length == 2)
    {
        string name = words[0];
        string surname = words[1];
        if (name[0] == surname[0])
        {
            Console.WriteLine("Перша буква імені та прізвища однакові");
        }
        else
        {
            Console.WriteLine("Перша буква імені та прізвища різні");
        }
    }
}