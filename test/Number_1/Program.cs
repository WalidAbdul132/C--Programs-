using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string: ");
            string input = Console.ReadLine();

            int vowelCount = 0;
            int length = 0;

            foreach (char c in input)
            {
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                {
                    vowelCount++;
                }
                length++;
            }

            Console.WriteLine("The total number of vowels in the string is: " + vowelCount);
            Console.WriteLine("The total number of characters in the string is: " + length);

            Console.ReadKey();
        }
    }
}
