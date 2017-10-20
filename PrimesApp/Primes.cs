using System;

namespace PrimesApp
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

            // Start at 2, 0 and 1 aren't prime numbers
            for(int i = 0; i <= primes.Length - 1; i++){
                // Maybe start all loops from the previous found prime number? 
                // Therefor you can skip all previous attempts.

                for (int j = 2; j <= 1000; j++)
                {
                    var result = IsPrime(j);
                    if (result){
                        Console.WriteLine(i + " " + j);
                        // break;
                    }
                }  
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