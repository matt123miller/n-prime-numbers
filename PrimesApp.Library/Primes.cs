using System;

namespace PrimesApp.Library
{
    public class Primes
    {
        public Primes()
        {
            
        }

        /// Find the first n prime numbers
        public int[] FindPrimes(int n) {

            var primes = new int[n];

            // The magic goes in the middle here.

            int previousPrime = primes[0];
            // Start at 2, 0 and 1 aren't prime numbers
            for(int i = 0; i < primes.Length; i++){
                // Maybe start all loops from the previous found prime number? 
                // Therefor you can skip all previous attempts.

                for (int j = previousPrime + 1; j <= int.MaxValue; j++)
                {
                    if (IsPrime(j))
                    {
                        primes[i] = j;
                        break;
                    }
                }  

                previousPrime = primes[i];
            }

            return primes;
        }

        public bool IsPrime(int number) 
        {
            // Skip the initial fails.
            if (number < 2)
            {
                return false;
            }
            
            for (var moduloNumber = 2; moduloNumber <= Math.Sqrt(number); moduloNumber++) 
            { 
                if (number % moduloNumber == 0) 
                { 
                    return false; 
                } 
            } 
            return true; 

            throw new NotImplementedException("Please return something before this point.");
        }
    }
}