using System;

namespace Roman_Numerals_to_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Conversion bite = new Conversion();
            bite.IntegerExchange("XIV");
            bite.IntegerExchange("VIII");

            Console.ReadLine();
        }
    }
}
