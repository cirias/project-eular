using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Common;

namespace ProjectEuler_0012
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            ulong sum = 0;
            ulong tempSum = 0;
            ulong lastAddNum = 1;
            ulong numOfFactors = 1;
            const int LENGTH = 500;
            ulong[] powerOfPrimes = new ulong[LENGTH];
            ulong[] topFiveHPrimes = new ulong[LENGTH];
            CommonMethod method = new CommonMethod();

            topFiveHPrimes = method.GetTopXPrimes(LENGTH);

            while (numOfFactors < 500)
            {
                sum += lastAddNum;
                lastAddNum++;
                numOfFactors = 1;
                tempSum = sum;
                powerOfPrimes = new ulong[LENGTH];

                for (i = 0; i < LENGTH; )
                {
                    if (tempSum % topFiveHPrimes[i] == 0)
                    {
                        tempSum /= topFiveHPrimes[i];
                        powerOfPrimes[i]++;
                        continue;
                    }
                    if (powerOfPrimes[i] != 0)
                    {
                        numOfFactors *= (powerOfPrimes[i] + 1);
                    }
                    i++;
                }
            }
        }
    }
}
