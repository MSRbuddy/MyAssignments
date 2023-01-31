using System;

namespace SampleProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = "";
            name = Console.ReadLine();
            Console.WriteLine("Enter your age: ");
            string age = "";
            age = Console.ReadLine();
            Console.WriteLine("Enter your location");
            string city = "";
            city = Console.ReadLine();
            Console.WriteLine("User name is" + name + "his/her age is" + age + "lives in" + city);
        }
    }
}
