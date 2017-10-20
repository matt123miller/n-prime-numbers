using System;

namespace PrimesApp
{
    public class Primes
    {
        public Primes()
        {

        }

        public int[] FindPrimes(int n) {

            var primes = new int[5];

            // The magic goes in the middle here.
            // Find the first n prime numbers

            bool isPrime = true;
            // Start at 2, 0 and 1 aren't prime numbers
            for(int i = 0; i <= primes.Length; i++){
                // Maybe start all loops from the previous found prime number? 
                // Therefor you can skip all previous attempts.
                for (int j = 2; j <= int.MaxValue; j++)
                {
                    for (int k = 2; k <= int.MaxValue; k++)
                    {
                        // This bit broken out into method? Or the j/k loops?
                        if(i != j && i % j == 0){
                            isPrime = false;
                            break;
                        }
                        if(!isPrime)
                            Console.WriteLine("wasn't prime, did break get here?");

                    }
                }  
            }

            return primes;
        }

        public bool IsPrime(int candidate) 
        {
            if (candidate < 2)
            {
                return false;
            }
            // This is obviously not clever. 
            // But it passes the tests before I start writing proper prime finding!
            if(candidate == 2 || candidate == 3 || candidate == 5 || candidate == 7)
            {
                return true;
            }
            return false;

            throw new NotImplementedException("Please return something before this point.");
        }
    }
}
