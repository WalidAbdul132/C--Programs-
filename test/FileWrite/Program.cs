using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWrite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] text = new string[2]; 

            Console.WriteLine("Enter a sentence to write into a file: ");
            text[0] = Console.ReadLine();

            Console.WriteLine("Enter a sentence to write into a file: ");
            text[1] = Console.ReadLine();

            //File.WriteAllText("mytest.txt", text);

            File.WriteAllLines("mytest.txt", text);

            //var line = File.ReadLines("mytest.txt").Skip(2 - 1).Take(1).First();

            string[] main = File.ReadAllLines("mytest.txt");

            var line = main[1];

            Console.WriteLine(line);

            //foreach (string a in line)
            //{
            //    Console.WriteLine(a);

            //}

            Console.ReadKey();
        }
    }
}
