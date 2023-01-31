using System;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, i, m = 0, flag = 0;
            Console.Write("Enter a Number: ");
            n = int.Parse(Console.ReadLine());
            m = n / 2;
            for (i=2; i<=m; i++)
            {
                if (n % i == 0)
                {
                    Console.Write("Given number is not a Prime Number.");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
                Console.Write("Given number is Prime Number");
        }
    }
}
