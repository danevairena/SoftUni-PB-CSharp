using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double yards = double.Parse(Console.ReadLine());
            double price = yards * 7.61;
            double discount = price * 0.18;
            double finalPrice = price - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");

        }
    }
}
