using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogPacks = int.Parse(Console.ReadLine());
            int catPacks = int.Parse(Console.ReadLine());

            double price = (4 * catPacks) + (2.5 * dogPacks);
            Console.WriteLine($"{price} lv.");
        }
    }
}
