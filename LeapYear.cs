using System;

namespace LeapYear
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int year;
            Console.Write("\nCheck whether the ginen year is leap year or not\n");
            Console.Write("\nEnter a year: \n");
            year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4) == 0)
                Console.WriteLine("Given year is a Leap Year.");
            else
                Console.WriteLine("Given year is not a Leap Year.");
        }
    }
}

