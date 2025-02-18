using System.Text;

Console.OutputEncoding = Encoding.UTF8;

string str;
Console.Write("Введіть строку: ");
str = Console.ReadLine();
string replacedStr = str.Replace(" ", "");
Console.WriteLine(replacedStr);