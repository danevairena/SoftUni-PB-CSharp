using System;
using System.Xml.Schema;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            int tax = int.Parse(Console.ReadLine());

            //prices calc
            double shoes = tax - tax * 0.4;
            double clothes = shoes - shoes * 0.2;
            double ball = clothes * 0.25;
            double others = ball * 0.2;

            //calculating
            double total = tax + shoes + clothes + ball + others;

            //output
            Console.WriteLine(total);
        }
    }
}
