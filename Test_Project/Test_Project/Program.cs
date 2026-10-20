using System;
using System.Numerics;

namespace Lessons
{

    class Program
    {
        static void Main(string[] args)
        {
            int pizzaCount = Convert.ToInt32(Console.ReadLine());
            double pizzaPrice = Convert.ToDouble(Console.ReadLine());
            int drinkCount = Convert.ToInt32(Console.ReadLine());
            double drinkPrice = Convert.ToDouble(Console.ReadLine());
            double disscountPrecent = Convert.ToDouble(Console.ReadLine());
            double couponAmaunt = Convert.ToDouble(Console.ReadLine());
            double deliverCost = Convert.ToDouble(Console.ReadLine());
            int friendCount = Convert.ToInt32(Console.ReadLine());

            double foodCost = (pizzaPrice * pizzaCount) + (drinkCount * drinkPrice);
            double disscountAmaunt = foodCost * disscountPrecent / 100;
            double finCost = foodCost - disscountAmaunt - couponAmaunt + deliverCost;
            double costPerFriend = finCost / friendCount;
            // $ - ИНТЕРПОЛЯЦИЯ СТРОК, ПОЗВОЛЯЕТ ВЫВОДИТ ЗНАЧЕНИЯ ПЕРЕМЕННОЙ ПО ЕЁ ИМЕНИ В ТЕКСТЕ
            Console.WriteLine($"ЦЕНА ЗА ЕДУ:  {foodCost:F2}");
            Console.WriteLine($"скидка: {disscountAmaunt:F2}");
            Console.WriteLine($"финальная цена: {finCost:F2}");
            Console.WriteLine($"цена за друга: {costPerFriend:F2}");

        }
    }

}