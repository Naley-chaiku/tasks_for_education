// task 1 27.10.26
//using System;
//class Program
//{
//    static void Main()
//    {
//        int number = Convert.ToInt32(Console.ReadLine());
//        bool bleble = true;

//        if (number <= 1)
//        {
//            bleble = false;
//        }
//        else
//        {

//            for (int i = 2; i < number; i++)
//            {
//                if (number % i == 0)
//                {
//                    bleble = false;
//                    break;

//                }
//            }
//        }
//        if (bleble)
//            Console.WriteLine("Простое");
//        else
//            Console.WriteLine("Не простое");
//    }
//}

//task 2 27.10.26
//using System;
//class Program
//{
//    static void Main()
//    {
//        int currentAmount = Convert.ToInt32(Console.ReadLine());
//        int targetAmount = Convert.ToInt32(Console.ReadLine());
//        int dailyAdd = Convert.ToInt32(Console.ReadLine());
//        int days = 0;

//        while (currentAmount < targetAmount)
//        {
//            currentAmount += dailyAdd;
//            days++;
//        }
//        Console.WriteLine($"Дней: {days}");
//        Console.WriteLine($"Накоплено: {currentAmount}");
//    }
//}

//task 3 27.10.26
//using System;
//class Program
//{
//    static void Main()
//    {
//        int n = Convert.ToInt32(Console.ReadLine());
//        if (n > 0)
//        {

//            int firstNumber = Convert.ToInt32(Console.ReadLine());
//            int min = firstNumber;
//            int max = firstNumber;

//            for (int i = 1; i < n; i++)
//            {
//                int currentNumber = Convert.ToInt32(Console.ReadLine());
//                if (currentNumber < min)
//                    min = currentNumber;
//                if (currentNumber > max)
//                    max = currentNumber;
//            }
//            Console.WriteLine($"Минимум: {min}");
//            Console.WriteLine($"Максимум: {max}");
//        }
//    }
//}