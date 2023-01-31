using System;

namespace PerfectNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, n;
            Console.Write("Enter the Number: ");
            num = int.Parse(Console.ReadLine());
            n = num;
            for ( int i = 1; i < num; i++ )
            {
                if (num % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine("\nEntered number is a Perfect Number.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nEntered number is not a Perfect Number.");
                Console.ReadLine();
            }
         }
    }
}
