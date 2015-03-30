using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace ProjectEuler_0003
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 1;
            long max = 600851475143;

            while (n < max)
            {
                if (GetLargestMultiple(n) != 1)
                {
                    n++;
                    continue;
                }
                else
                {
                    if (max % n == 0)
                    {
                        max = max / n;
                    }
                    n++;
                }
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }

        static public long GetLargestMultiple(long n)
        {
            long LargestMultiple = 0;
            long i = n - 1;

            while (i >= 1)
            {
                if (n % i == 0)
                {
                    LargestMultiple = i;
                    break;
                }
                i--;
            }

            return LargestMultiple;
        }
    }
}
