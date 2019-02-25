using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square
{
    class Program
    {
        static double Square(double Number)
        {
            return Number * Number;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number :");
            double Num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"The square of {Num} is {Square(Num)}");
            Console.ReadKey();
        }
    }
}
