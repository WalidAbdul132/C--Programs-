using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    delegate int RectangleCalculator(int length, int breadth);
    internal class Program6
    {
        static void Main(string[] args)
        {
            RectangleCalculator calculator = CalculateArea;

            Console.WriteLine("Enter the length of the rectangle: ");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the breadth of the rectangle: ");
            int breadth = Convert.ToInt32(Console.ReadLine());

            int area = calculator(length, breadth);
            Console.WriteLine("Area of the rectangle: " + area);

            Console.ReadKey();
        }
        static int CalculateArea(int length, int breadth)
        {
            int result = length * breadth;
            return result;
        }
    }
}
