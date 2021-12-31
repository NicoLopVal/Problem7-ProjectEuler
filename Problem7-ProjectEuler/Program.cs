using System;
using System.Collections.Generic;

namespace Problem7_ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>();
            primes.Add(2);
            int primeCount = 1;
            int generalCount = 3;

            while (true)
            {
                bool primeFound = true;
                foreach(int prime in primes)
                {
                    if(generalCount % prime == 0)
                    {
                        primeFound = false;
                        break;
                    }
                }
                if(primeFound == true)
                {
                    primes.Add(generalCount);
                    primeCount++;
                }

                if (primeCount == 10001)
                    break;
                generalCount++;

            }

            Console.WriteLine(primes[10000] + " is the 10 001st prime number");
        }
    }
}
