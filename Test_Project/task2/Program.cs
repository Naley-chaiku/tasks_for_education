using System;
using System.Numerics;

namespace Lessons
{

    class Program
    {
        static void Main(string[] args)
        {
            int hoursArrival = Convert.ToInt32(Console.ReadLine());
            int minutesArrinal = Convert.ToInt32(Console.ReadLine());
            int secondsArrival = Convert.ToInt32(Console.ReadLine());
            int travelMinutes = Convert.ToInt32(Console.ReadLine());
            int travelSeconds = Convert.ToInt32(Console.ReadLine());
            int stopMinutes = Convert.ToInt32(Console.ReadLine());

            // переводим всё секунды
            int totalSeconds = (hoursArrival * 3600) + (minutesArrinal * 60) + secondsArrival;
            // время в пути, двидение и остоновка в сек
            int travelTimeInSeconds = (travelMinutes * 60) + travelSeconds;
            int stopTimeInSeconds = stopMinutes * 60;
            int totalTripSeconds = travelTimeInSeconds + stopTimeInSeconds; //общее время в пути
                                                                            // время прибытия
            int totalArrivalSeconds = totalSeconds + totalTripSeconds;
            // в какой день приехал (24часа * 60минут * 60секунд = 86400 секунд)
            int arrivalDay = totalArrivalSeconds / 86400;
            // Остаток секунд после вычета полных дней
            int remainingSeconds = totalArrivalSeconds % 86400;
            int arrivalHours = remainingSeconds / 3600;
            remainingSeconds = remainingSeconds % 3600;
            int arrivalMinutes = remainingSeconds / 60;
            int arrivalSeconds = remainingSeconds % 60;
            Console.WriteLine(arrivalDay);
            Console.WriteLine(arrivalHours);
            Console.WriteLine(arrivalMinutes);
            Console.WriteLine(arrivalSeconds);

        }
    }

}