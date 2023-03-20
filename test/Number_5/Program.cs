using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Number_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of lines to write in the file: ");
            int numLines = Convert.ToInt32(Console.ReadLine());

            string[] lines = new string[numLines];
            for (int i = 0; i < numLines; i++)
            {
                Console.WriteLine("Enter line " + (i + 1) + ": ");
                lines[i] = Console.ReadLine();
            }

            File.WriteAllLines("mytest.txt", lines);

            Console.WriteLine("Enter the line number to display: ");
            int lineNumber = Convert.ToInt32(Console.ReadLine());

            string line = File.ReadLines("mytest.txt").Skip(lineNumber - 1).Take(1).First();

            Console.WriteLine("The content of line " + lineNumber + " of the file mytest.txt is: " + line);

            Console.ReadKey();
        }
    }
}
