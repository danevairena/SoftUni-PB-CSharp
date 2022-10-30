using System;
using System.Xml.Schema;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            //calculating
            double maxVolume = (lenght * width * height) / 1000.0;
            double occupied = percent / 100;
            double water = maxVolume * (1 - occupied);

            //output
            Console.WriteLine(water);
        }
    }
}
