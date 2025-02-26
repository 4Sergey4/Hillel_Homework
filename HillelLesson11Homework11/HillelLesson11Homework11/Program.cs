using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Random random = new Random();
string[] words = { "собака", "галактика", "манго", "рибалка", "гепард", "яблуко", "дерево" };
string word = words[random.Next(words.Length)];
string guessedWord = new string('*', word.Length);
char letter;
int attemps = 6;

Console.WriteLine("Вітаю у грі шибениця");
Console.WriteLine($"Відгадати слово {guessedWord}");
Console.WriteLine($"У вас є {attemps} спроб");
while (attemps > 0)
{
    Console.Write("Введіть букву: ");
    letter = Convert.ToChar(Console.ReadLine());
    if (word.Contains(letter))
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == letter)
            {
                guessedWord = guessedWord.Remove(i, 1).Insert(i, letter.ToString());
            }
        }
        Console.WriteLine($"Відгадане слово: {guessedWord}");
        if (word == guessedWord)
        {
            Console.WriteLine("Ви виграли");
            break;
        }
    }
    else
    {
        attemps--;
        Console.WriteLine($"Ви не вгадали. У вас залишилось {attemps} спроб");
    }
}