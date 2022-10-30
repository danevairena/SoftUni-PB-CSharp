using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //input
            double deposit = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double YearInterestRate = double.Parse(Console.ReadLine())/100;
            
            //calculate and output
            double sum = deposit + period * ((deposit * YearInterestRate) / 12);
            Console.WriteLine(sum);
        }
    }
}
