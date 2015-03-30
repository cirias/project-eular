using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler_0004
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 9;
            int b = 9;
            int c = 9;
            int n = 0;
            int i = 999;

            while (a > 0)
            {
                while (b >= 0)
                {
                    while (c >= 0)
                    {
                        while (i > 100)
                        {
                            n = a * 100000 + b * 10000 + c * 1000 + c * 100 + b * 10 + a;
                            if ((n / i) < 1000 && (n / i) > 99 && n % i == 0)
                            {
                                Console.WriteLine(n);
                                Console.ReadLine();
                            }
                            i--;
                        }
                        i = 999;
                        c--;
                    }
                    b--;
                    c = 9;
                }
                a--;
                b = 9;
            }


        }
    }
}
