using System;

namespace Uppgift
{
    class Program
    {

        static void Main(string[]args)
        {

            Console.WriteLine("Vilken är din favoritbok?");
            string bok =Console.ReadLine();
            
            Console.Clear();
            Console.WriteLine("Din favoritbok är alltså " + bok);
            Console.ReadKey();
        }
    }


}