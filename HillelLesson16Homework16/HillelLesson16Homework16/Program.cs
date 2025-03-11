using System.Text;

namespace HillelLesson16Homework16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Введіть шлях до файлу: ");
            string input = Console.ReadLine();
            Console.WriteLine("Введіть шлях куди скопіювати файл: ");
            string output = Console.ReadLine();

            FileCopier fileCopier = new FileCopier(input, output);
            fileCopier.GetInputPath(input);
            fileCopier.GetOutputPath(output);
            fileCopier.CopyFile();

        }
    }
}
