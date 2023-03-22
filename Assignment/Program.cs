using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            int aCount = 0;
            int eCount = 0;
            int iCount = 0;
            int oCount = 0;
            int uCount = 0;

            foreach (char c in input)
            {
                if (c == 'a' || c == 'A')
                {
                    aCount++;
                }
                else if (c == 'e' || c == 'E')
                {
                    eCount++;
                }
                else if (c == 'i' || c == 'I')
                {
                    iCount++;
                }
                else if (c == 'o' || c == 'O')
                {
                    oCount++;
                }
                else if (c == 'u' || c == 'U')
                {
                    uCount++;
                }
            }

            Console.WriteLine("Number of A's: " + aCount);
            Console.WriteLine("Number of E's: " + eCount);
            Console.WriteLine("Number of I's: " + iCount);
            Console.WriteLine("Number of O's: " + oCount);
            Console.WriteLine("Number of U's: " + uCount);

            Console.ReadKey();
        }
    }
}

