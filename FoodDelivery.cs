using System;
using System.Xml.Schema;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prices
            double chickenMenu = 10.35;
            double fishMenu = 12.4;
            double vegetMenu = 8.15;
            double delivery = 2.5;

            //input
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int veget = int.Parse(Console.ReadLine());

            //calculating
            double totalPrice = chicken * chickenMenu + fish * fishMenu + veget * vegetMenu;
            double desert = totalPrice * 0.2;
            double finalPrice = totalPrice + desert + delivery;

            //output
            Console.WriteLine(finalPrice);
        }
    }
}
