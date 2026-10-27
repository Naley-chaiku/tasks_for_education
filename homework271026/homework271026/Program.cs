using System;
class Program
{
    static void Main()
    {
        int number = Convert.ToInt32(Console.ReadLine());
        bool bleble = true;

        if (number <= 1)
        {
            bleble = false;
        }
        else
        {

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    bleble = false;
                    break;
                    
                }
            }
        }
        if (bleble)
            Console.WriteLine("Простое");
        else
            Console.WriteLine("Не простое");
    }
}