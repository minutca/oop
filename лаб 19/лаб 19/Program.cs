using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Таблиця множення (шістнадцяткова система):\n");

        for (int i = 1; i <= 15; i++)
        {
            for (int j = 1; j <= 15; j++)
            {
                int result = i * j;
                string hex = result.ToString("X");

                Console.Write($"{hex}\t");
            }
            Console.WriteLine();
        }
    }
}
