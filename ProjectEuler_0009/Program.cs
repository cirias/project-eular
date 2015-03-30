using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler_0009
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            for (a = 1; a <= 333; a++)
            {
                for (b = 1; (a + b) < 1000; b++)
                {
                    c = 1000 - a - b;

                    if (c * c == a * a + b * b)
                    {
                        break;
                    }
                }
            }
        }
    }
}
