using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int naylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int diluent = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());

            //calculating
            double materialsPrice = (naylon + 2) * 1.5 + (paint * 14.5) * 1.1 + diluent * 5 + 0.4;
            double hourPrice = materialsPrice * 0.3;
            double workPrice = hourPrice * hours;
            double totalPrice = workPrice + materialsPrice;

            //output
            Console.WriteLine(totalPrice);
        }
    }
}
