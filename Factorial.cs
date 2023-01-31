using System;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //factorial
            Console.WriteLine("Enter the number for factorial");
            int n = int.Parse(Console.ReadLine());
            int value = 1;
            for (int i = 1; i <= n; i++)
            {
                value = value * i;
            }
            Console.WriteLine(value);
        }
    }
}

