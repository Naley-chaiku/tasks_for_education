
//задание 4

using System;

class Program
{
    static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        double average = GetAverage(numbers);

        Console.WriteLine($"среднее: {average:F2}");
    }

    static double GetAverage(int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        double result = (double)sum / numbers.Length;

        return result;
    }
}

// задание 3

//using System;

//class Program
//{
//    static void Main()
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        int[] numbers = new int[n];

//        for (int i = 0; i < n; i++)
//        {
//            numbers[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        int divisor = Convert.ToInt32(Console.ReadLine());

//        int count = CountMultiples(numbers, divisor);

//        Console.WriteLine($"количество: {count}");
//    }

//    static int CountMultiples(int[] numbers, int divisor)
//    {
//        int count = 0; 

//        foreach (int number in numbers)
//        {
//            if (number % divisor == 0)
//            {
//                count++;
//            }
//        }

//        return count;
//    }
//}


//задание 2


//using System;

//class Program
//{
//    static void Main()
//    { 
//        int a = Convert.ToInt32(Console.ReadLine());
//        int b = Convert.ToInt32(Console.ReadLine());
//        int c = Convert.ToInt32(Console.ReadLine());

//        int max = GetMax(a, b, c);
//        Console.WriteLine($"Максимум: {max}");
//    }

//    static int GetMax(int a, int b, int c)
//    {
//        int max = a;

//        if (b > max)
//        {
//            max = b;
//        }

//        if (c > max) 
//        {
//            max = c;
//        }

//        return max;

//    }
//}

