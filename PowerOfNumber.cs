using System;

namespace PowerOfNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base value: ");
            string number1 = Console.ReadLine();
            int Base = int.Parse(number1);
            Console.WriteLine("Enter power for given number: ");
            string number = Console.ReadLine();
            int power = int.Parse(number);
            int result = 1;
            while(power>0)
            {
                result = result * Base;
                power--;
            }
            Console.WriteLine("power of the given number with power: " + number + " is: " + result);
        }
    }
}
