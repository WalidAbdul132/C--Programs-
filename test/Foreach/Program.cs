using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];

            num[0] = 2;
            num[1] = 4;
            num[2] = 6;
            num[3] = 8;
            num[4] = 9;

            int size = num.Length;

            foreach (int a in num)
            {
                Console.WriteLine(a);
                Console.WriteLine(size);
            }

            Console.ReadKey();
        }
    }
}
