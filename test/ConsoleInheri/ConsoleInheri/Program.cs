using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInheri
{
    class Program
    {
        static void Main(string[] args)
        {
            
                ChildClass childClass = new ChildClass();
                // Calling method of base class 
                childClass.Name = "David";
                childClass.PrintName();
                childClass.PrintAge(29);
            Console.ReadKey();
           
        }
    }
}
