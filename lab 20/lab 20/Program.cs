using System;

struct Time
{
    public int hours;
    public int minutes;
    public int seconds;
}

class Program
{
    static void Main()
    {
        try
        {
            Time start = new Time { hours = 10, minutes = 15, seconds = 30 };
            Time end = new Time { hours = 11, minutes = 20, seconds = 10 };

            int duration = GetCallDuration(start, end);
            Console.WriteLine($"Тривалість розмови: {duration} хв");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Помилка: {ex.Message}");
        }
    }

    static int GetCallDuration(Time start, Time end)
    {
        // переводимо час у секунди
        int startSec = start.hours * 3600 + start.minutes * 60 + start.seconds;
        int endSec = end.hours * 3600 + end.minutes * 60 + end.seconds;

        //перевірка виключення
        if (endSec < startSec)
        {
            throw new Exception("Час завершення менший за час початку!");
        }

        int totalSeconds = endSec - startSec;
        // у хвилини округлення вверх
        int minutes = totalSeconds / 60;

        if (totalSeconds % 60 != 0)
        {
            minutes++; 
        }

        return minutes;
    }
}