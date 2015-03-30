using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace TestPlatform
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonMethod method = new CommonMethod();

            method.GetPrimes(2000000);

            if (method.IsPrime(65521))
            {
                Console.WriteLine("Yes");
                Console.ReadLine();
            }
        }
    }
}
