using System;

namespace Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "1";
            string b = "2";
            int aa = int.Parse(a);
            int bb = int.Parse(b);
            int totalNumber = aa + bb;
            string total = a + b;
            Console.WriteLine(total);
            Console.WriteLine(totalNumber);
        }
    }
}
