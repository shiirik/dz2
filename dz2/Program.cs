using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите несколько чисел через пробел:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        double sum = 0;

        foreach (string number in numbers)
        {
            if (double.TryParse(number, out double parsedNumber))
            {
                sum += parsedNumber;
            }
            else
            {
                Console.WriteLine($"Неверное значение: {number}");
            }
        }

        Console.WriteLine($"Сумма введенных чисел: {sum}");
    }
}
