using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_2
{
    internal class Program
    {
        private static char maxCha(String str)
            {
                int[] countArray = new int[256];
                int maxValue = 0;
                char resultChar = 'i';

                for (int i = 0; i < str.Length; i++)
                {
                    countArray[str[i]]++;

                    if (countArray[str[i]] > maxValue)
                    {
                        maxValue = countArray[str[i]];
                        resultChar = str[i];
                    }
                }

                return resultChar;
            }
        static void Main(string[] args)
        {
                Console.WriteLine("Enter a string :");
                String Str = Console.ReadLine();

                Console.WriteLine("The character with maximum occurrence is : " + maxCha(Str));

                Console.ReadKey();
            }
        }

    }

