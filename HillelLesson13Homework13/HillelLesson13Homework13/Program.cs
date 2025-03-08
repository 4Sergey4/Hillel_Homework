using System.Text;

namespace HillelLesson13Homework13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] array = new int[100];

            Console.WriteLine("Масив до сортування: ");
            FillingArray(array);
            Console.WriteLine();

            //1.Залишити всі значення більше за 0 та помножити їх на 10.
            var sortArray = array.Where(array => array > 0).Select(array => array * 10).ToArray();
            Console.WriteLine("Відсортована колекція та домножена на 10 ");
            PrintArray(sortArray);
            Console.WriteLine();

            //2.Впорядкувати елементи з пункту 1 за спаданням.
            var sortArray2 = sortArray.OrderDescending().ToArray();
            Console.WriteLine("\nЕлементи впорядковані по спаданню: ");
            PrintArray(sortArray2);
            Console.WriteLine();

            //3.Видалити всі дублікати з пункту 2.
            var sortArray3 = sortArray2.Distinct().ToArray();
            Console.WriteLine("\nВидалення дублікатів: ");
            PrintArray(sortArray3);
            Console.WriteLine();

            //4.Перевірити, чи є хоч одне число більше за 20 в колекції з пункту 3.
            bool MoreThanTwenty = sortArray3.Any(sortArray3 => sortArray3 > 20);
            if(MoreThanTwenty)
            {
                Console.WriteLine("\nМасив містить елементи більше 20");
            }
            else
            {
                Console.WriteLine("\nМасив не містить елементів більше 20");
            }

            //5.Видалити перші два елементи колекції з пункту 3
            var sortArray5 = sortArray3.Skip(2).ToArray();
            Console.WriteLine("\nВидалення перших двох елементів");
            PrintArray(sortArray5);

            //6.Знайти середнє значення колекції з пункту 5
            double average = sortArray5.Average();
            Console.WriteLine($"\nСередне значення: {Math.Round(average, 2)}");
            Console.WriteLine();

            //7.Дописати до колекції з пункту 5 в кінці числа 3, 2, 1
            int[] newNumer = { 3, 2, 1 };
            var finalResult = sortArray5.Concat(newNumer).ToArray();
            Console.WriteLine("\nДописування 3, 2, 1 у кінець колекції: ");
            PrintArray(finalResult); 

            //8.Знайти загальну кількість елементів у колекції з пункту 7
            int count = finalResult.Count();
            Console.WriteLine();
            Console.WriteLine($"\nЗагальна кількість елементів: {count}");

            //9.Розвернути колекцію з пункту 7 в зворотньому порядку.
            var sortArray8 = finalResult.Order().ToArray();
            Console.WriteLine("\nВпорядкування елементів по зростанню: ");
            PrintArray(sortArray8);
            Console.WriteLine();

            //10.Залишити тільки перші 5 елементів в колекції з пункту 9.
            var sortArray9 = sortArray8.Take(5).ToArray();
            Console.WriteLine("\nВидалення всіх елементів окрім перших 5-ти: ");
            PrintArray(sortArray9);
        }
        public static void FillingArray(int[] array)
        {
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(-100, 100);
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }
        public static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
        }
    }
}
