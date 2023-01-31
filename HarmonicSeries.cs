using System;

namespace HarmonicSeries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            double s = 0.0;

            Console.Write("\n\n");
            Console.Write("Calculate the harmonic seriesand their sum: \n");
            Console.Write("\n\n");

            Console.Write("Enter the no.of terms: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for ( i=1; i<=n; i++ )
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of series upto {0} terms : {1} \n", n, s);
        }
    }
}
