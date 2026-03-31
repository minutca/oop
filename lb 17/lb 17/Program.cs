using System;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Введіть десяткове число (через пробіл):");

            int[] decDigits = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            Console.WriteLine("Введіть двійкове число (через пробіл):");

            int[] binDigits = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (int d in binDigits)
            {
                if (d != 0 && d != 1)
                {
                    Console.WriteLine("Помилка: двійкове число може містити тільки 0 і 1!");
                    return;
                }
            }

            Decimal d1 = new Decimal(decDigits);
            Binary b1 = new Binary(binDigits);

            Console.WriteLine("\nРезультат:");

            Console.WriteLine("Decimal: " + d1.Print());
            Console.WriteLine("Binary: " + b1.Print());

            Console.WriteLine("Сума = " + d1.Add(b1));
            Console.WriteLine("Різниця = " + d1.Sub(b1));
        }
        catch
        {
            Console.WriteLine("Помилка вводу! Вводь тільки числа через пробіл.");
        }

        Console.ReadLine();
    }
}
