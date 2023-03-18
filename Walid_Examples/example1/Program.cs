using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            int a; int b = 20, result;
            Console.WriteLine("Enter the value of a: ");
            s = Console.ReadLine();
            a = Convert.ToInt32(s);
            //a = int.Parse(s);
            result = a + b;
            Console.WriteLine("{0} + {1} is {2}", a, b, result);

            Console.ReadKey();
        }
    }
}
