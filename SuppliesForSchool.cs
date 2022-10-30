using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            //input
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int litersCleaner = int.Parse(Console.ReadLine());
            int discountPercentage = int.Parse(Console.ReadLine());

            //calculating
            double totalPrice = (pens * 5.8) + (markers * 7.2) + (litersCleaner * 1.2);
            double finalPrice = totalPrice - (totalPrice * discountPercentage / 100);
            //output
            Console.WriteLine(finalPrice);
            
        }
    }
}
