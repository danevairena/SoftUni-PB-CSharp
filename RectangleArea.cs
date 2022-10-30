using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prompt for height
            Console.WriteLine("Enter heihgt:");
            int height = int.Parse(Console.ReadLine());

            //prompt for width
            Console.WriteLine("Enter width:");
            int width = int.Parse(Console.ReadLine());

            //calculate
            int area = height * width;
            Console.WriteLine($"Your rectangle area is {area}");
        }
    }
}
