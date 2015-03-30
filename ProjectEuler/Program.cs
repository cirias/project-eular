using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1;
            double b = 1;
            double c = a + b;
            double temp = 0;
            double sum = 0;
            while (c < 4000000)
            {
                if (c % 2 == 0)
                {
                    sum += c;
                    Console.WriteLine("sum = " + sum.ToString());
                }
                temp = a;
                a = b;
                b = c;
                c = a + b;
                Console.WriteLine("c = "+c.ToString());
            }
            Console.ReadLine();
        }
    }
}
