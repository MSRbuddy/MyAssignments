using System;

namespace VowelOrConsonent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enterb a Alphabet: ");
            char letter = char.Parse(Console.ReadLine());

              if ( letter=='a' || letter=='A' || letter=='e' || letter=='E' || letter=='i' || letter=='I' || letter=='o' || letter=='O' || letter=='u' || letter=='U' )
                Console.WriteLine("It is a Vowel");
                else
                Console.WriteLine("It is a Consonent");
                Console.ReadLine();
        }
    }
}
