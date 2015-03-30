using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Common
{
    public class CommonMethod
    {
        public bool IsPrime(UInt64 n)
        {
            List<ulong> primes = new List<ulong> { 2, 3, 5, 7, 11, 13 };
            int i = 0;
            ulong newPrime = 0;
            int k = 0;

            bool blnIsPrime = false;

            for (i = 0; primes[i]*primes[i]<n&& i < primes.Count - 1; i++)
            {
                if (n % primes[i] == 0)
                {
                    return false;
                }
            }

            for (newPrime = primes[primes.Count - 1]+2; newPrime < n; newPrime += 2)
            {
                blnIsPrime = true;

                for (k = 1; primes[k] * primes[k] <= newPrime; k++)
                {
                    if (newPrime % primes[k] == 0)
                    {
                        blnIsPrime = false;
                        break;
                    }
                }

                if (blnIsPrime)
                {
                    primes.Add(newPrime);
                    if (n % newPrime == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void GetPrimes(ulong max)
        {
            List<ulong> primes = new List<ulong> { 2, 3, 5, 7, 11, 13 };
            //ulong sumOfPrimes = 2 + 3 + 5 + 7 + 11 + 13;
            ulong newPrime = 0;
            int k = 0;
            bool blnIsPrime = false;

            for (newPrime = primes[primes.Count - 1] + 2; newPrime < max; newPrime += 2)
            {
                blnIsPrime = true;

                for (k = 0; (primes[k] * primes[k]) <= newPrime; k++)
                {
                    if (newPrime % primes[k] == 0)
                    {
                        blnIsPrime = false;
                        break;
                    }
                }

                if (blnIsPrime)
                {
                    primes.Add(newPrime);
                    //sumOfPrimes += newPrime;
                }
            }
        }

        public ulong[] GetTopXPrimes(uint n)
        {
            List<ulong> primes = new List<ulong> { 2, 3, 5, 7, 11, 13 };
            ulong newPrime = 0;
            int k = 0;
            bool blnIsPrime = false;

            for (newPrime = primes[primes.Count - 1] + 2; primes.Count < n; newPrime += 2)
            {
                blnIsPrime = true;

                for (k = 0; (primes[k] * primes[k]) <= newPrime; k++)
                {
                    if (newPrime % primes[k] == 0)
                    {
                        blnIsPrime = false;
                        break;
                    }
                }

                if (blnIsPrime)
                {
                    primes.Add(newPrime);
                }
            }

            return primes.ToArray();
        }

        
    }
}
