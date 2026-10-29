using System;

class Program
{
    static void Main()
    {
        int count = 0;
        int sum = 0;
        int min = 6;
        int max = 0;
        int fiveCount = 0;

        while (true)
        {
            int grade = Convert.ToInt32(Console.ReadLine());

            if (grade == 0) break;

            if (grade < 1 || grade > 5)
            {
                Console.WriteLine("Некорректная оценка");
                continue;
            }

            count++;
            sum += grade;

            if (grade < min) min = grade;
            if (grade > max) max = grade;
            if (grade == 5) fiveCount++;
        }

        if (count == 0)
        {
            Console.WriteLine("Нет данных");
        }
        else
        {
            double average = (double)sum / count;
            Console.WriteLine($"Количество: {count}");
            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Минимум: {min}");
            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Среднее: {average}");
            Console.WriteLine($"Пятёрок: {fiveCount}");
        }
    }
}