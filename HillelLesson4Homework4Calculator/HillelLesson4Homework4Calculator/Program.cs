using System.Text;

Console.OutputEncoding = Encoding.UTF8;

double firstNumber;
double secondNumber;
double result;
char operation;
while (true) 
{
    Console.Write("Введіть перше число:");
    firstNumber = Convert.ToDouble(Console.ReadLine());

    Console.Write("Введіть операцію (+, -, *, /):");
    operation = Convert.ToChar(Console.ReadLine());

    Console.Write("Введіть друге число:");
    secondNumber = Convert.ToDouble(Console.ReadLine());

    switch (operation)
    {
        case '+':
            result = (firstNumber + secondNumber);
            Console.WriteLine($"Результат: {result}\n");
            break;

        case '-':
            result = (firstNumber - secondNumber);
            Console.WriteLine($"Результат: {result}\n");
            break;
        case '*':
            result = (firstNumber * secondNumber);
            Console.WriteLine($"Результат: {result}\n");
            break;
        case '/':
            if (secondNumber == 0)
            {
                Console.WriteLine("0\n");
            }
            else
            {
                result = (firstNumber / secondNumber);
                Console.WriteLine($"Результат: {result}\n");
            }
            break;
    }
} 