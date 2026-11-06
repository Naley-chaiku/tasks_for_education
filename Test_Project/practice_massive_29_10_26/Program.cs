using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("введите длинну массива: ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("введите элементы массива: ");
        int[] numbers = new int[n];

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sumPositive = 0;
        int countNegative = 0;
        int countZero = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                sumPositive += numbers[i];
            }
            else if (numbers[i] < 0)
            {
                countNegative++;
            }
            else
            {
                countZero++;
            }

        }
        Console.WriteLine($"Сумма положительных: {sumPositive}");
        Console.WriteLine($"Отрицательный: {countNegative}");
        Console.WriteLine($"Нулей: {countZero}");

    }
}

////////Задача 2 Элементы с чётными индексами

////////using System;

////////class Program
////////{
////////    static void Main()
////////    {
////////        int n = Convert.ToInt32(Console.ReadLine());
////////        int[] numbers = new int[n];

////////        for (int i = 0; i < n; i++)
////////        {
////////            numbers[i] = Convert.ToInt32(Console.ReadLine());
////////        }

////////        int sum = 0;
////////        for (int i = 0; i < n; i += 2)
////////        {
////////            sum += numbers[i];
////////        }

////////        Console.WriteLine($"Сумма: {sum}");
////////    }
////////}

////////задача 3, поиск заданного числа

//////using System;

//////class Program
//////{
//////    static void Main()
//////    {
//////        int n = Convert.ToInt32(Console.ReadLine());
//////        int[] numbers = new int[n];

//////        for (int i = 0; i < n; i++)
//////        {
//////            numbers[i] = Convert.ToInt32(Console.ReadLine());
//////        }

//////        int x = Convert.ToInt32(Console.ReadLine());
//////        int count = 0; 

//////        for (int i = 0; i < n; i++)
//////        {
//////            if (numbers[i] == x)
//////            {
//////                Console.WriteLine($"Индекс: {i}");
//////                count++;
//////            }
//////        }

//////        if (count > 0)
//////        {
//////            Console.WriteLine($"Количество: {count}");
//////        }
//////        else
//////        {
//////            Console.WriteLine("Число не найдено");
//////        }
//////    }
//////}

////////задача 4, минимум максимум и их индексы

////using System;

////class Program
////{
////    static void Main()
////    {
////        int n = Convert.ToInt32(Console.ReadLine());
////        int[] numbers = new int[n];

////        for (int i = 0; i < n; i++)
////        {
////            numbers[i] = Convert.ToInt32(Console.ReadLine());
////        }

////        int minVal = numbers[0];
////        int minIndex = 0;
////        int maxVal = numbers[0];
////        int maxIndex = 0;

////        for (int i = 1; i < n; i++)
////        {
////            if (numbers[i] < minVal) 
////            {
////                minVal = numbers[i];
////                minIndex = i;
////            }

////            if (numbers[i] > maxVal) 
////            {
////                maxVal = numbers[i];
////                maxIndex = i;
////            }
////        }

////        Console.WriteLine($"Минимум: {minVal}");
////        Console.WriteLine($"Индекс минимума: {minIndex}");
////        Console.WriteLine($"Максимум: {maxVal}");
////        Console.WriteLine($"Индекс максимума: {maxIndex}");
////    }
////}

//////задача 5, замена элементов диапазода

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

//        int replacementsCount = 0;

//        for (int i = 0; i < n; i++)
//        {
//            if (numbers[i] >= -5 && numbers[i] <= 5)
//            {
//                numbers[i] = 0;
//                replacementsCount++;
//            }
//        }

//        Console.WriteLine($"Замен: {replacementsCount}");
//        Console.WriteLine("Массив:");

//        for (int i = 0; i < n; i++)
//        {
//            Console.WriteLine(numbers[i]);
//        }
//    }
//

// задача 7 разварот массива

using System;

class Program
{
   

    
}