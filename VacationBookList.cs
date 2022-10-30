using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int numPages = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            //calculating
            int totalTime = numPages / pagesPerHour;
            int hours = totalTime / days;

            //output
            Console.WriteLine(hours);
        }
    }
}
