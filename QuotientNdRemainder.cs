using System;

namespace Quotient_n_Remainder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend = 25, divisor = 4;
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;

            Console.WriteLine("Dividend : {0} Divisor : {1}", dividend, divisor);

            Console.WriteLine("Quotuent =" + quotient);
            Console.WriteLine("Remainder =" + remainder);
            Console.ReadLine();
        }
    }
}
