using System;
class Program
{
    static void Main()
    {
        // 🔹 1. ОДНОВИМІРНИЙ МАСИВ
        Console.Write("Введіть кількість елементів: ");
        int n = int.Parse(Console.ReadLine());
        double[] arr = new double[n];
        // Ввід масиву
        for (int i = 0; i < n; i++)
        {
            Console.Write($"arr[{i}] = ");
            arr[i] = double.Parse(Console.ReadLine());
        }
        //  Мінімальний за модулем
        double minAbs = Math.Abs(arr[0]);

        for (int i = 1; i < n; i++)
        {
            if (Math.Abs(arr[i]) < minAbs)
                minAbs = Math.Abs(arr[i]);
        }
        Console.WriteLine("Мінімальний за модулем: " + minAbs);
        //  Сума після першого нуля
        double sum = 0;
        bool foundZero = false;
        for (int i = 0; i < n; i++)
        {
            if (foundZero)
                sum += Math.Abs(arr[i]);

            if (arr[i] == 0)
                foundZero = true;
        }
        Console.WriteLine("Сума після першого нуля: " + sum);
        //  Перетворення масиву 
        double[] result = new double[n];
        int index = 0;
        // парні індекси
        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                result[index] = arr[i];
                index++;
            }
        }
        // непарні індекси
        for (int i = 0; i < n; i++)
        {
            if (i % 2 != 0)
            {
                result[index] = arr[i];
                index++;
            }
        }

        Console.WriteLine("Новий масив:");
        for (int i = 0; i < n; i++)
        {
            Console.Write(result[i] + " ");
        }
        Console.WriteLine();
        //  2. ДВОВИМІРНИЙ МАСИВ
        Console.Write("\nВведіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Введіть кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        // Ввід матриці
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"matrix[{i},{j}] = ");
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }
        // Вивід матриці
        Console.WriteLine("\nМатриця:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        // Сума 3-го стовпця (перші 2 елементи)
        if (cols >= 3 && rows >= 2)
        {
            int sumCol = matrix[0, 2] + matrix[1, 2];
            Console.WriteLine("Сума елементів 3-го стовпця: " + sumCol);
        }
        else
        {
            Console.WriteLine("Недостатньо елементів для 3-го стовпця");
        }
        // Добуток 2-го рядка (перші 2 елементи)
        if (rows >= 2 && cols >= 2)
        {
            int product = matrix[1, 0] * matrix[1, 1];
            Console.WriteLine("Добуток елементів 2-го рядка: " + product);
        }
        else
        {
            Console.WriteLine("Недостатньо елементів для 2-го рядка");
        }
    }
}