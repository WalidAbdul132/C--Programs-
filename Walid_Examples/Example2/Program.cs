using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone Phone1 = new Phone("iPhone Xr", 100, "Apple");

            Console.WriteLine("the name of the phone is " + Phone1.name);
            Console.WriteLine("It costs {0} dollars", Phone1.price);
            Console.WriteLine("{0} Company made the phone", Phone1.Company);
            Console.WriteLine(Phone1.isExpensive());

            Console.ReadKey();

        }
    }
}
