using System;

namespace Swap
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, temp;
            Console.Write("\nEnter the first number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the second number: ");
            num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
            Console.Write("\nAfter Swapping the numbers");
            Console.Write("\nFirst number: " + num1);
            Console.Write("\nSecond number: " + num2);
            Console.ReadLine();
        }
    }
}
