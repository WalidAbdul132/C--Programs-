using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            int sum = GetSingleDigitSum(num);

            Console.WriteLine("Sum of single digits: " + sum);

            Console.ReadLine();
        }

        static int GetSingleDigitSum(int n)
        {
            if (n < 10)
            {
                return n;
            }

            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }

            return GetSingleDigitSum(sum);
        }
    }
}