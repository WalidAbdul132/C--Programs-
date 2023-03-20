using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleInheri
{
    class ChildClass:ParentClass
    {
        public void PrintAge(int Age) => Console.WriteLine($"Age : {Age}");
    }
}
