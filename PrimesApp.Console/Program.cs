using System;
using PrimesApp.Library;

namespace PrimesAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeCount = int.Parse(args[0]);


            // The required objects
            var primeFinder = new Primes();
            IPrimeOutput outputGenerator;

            int[] primes = primeFinder.FindPrimes(primeCount);
            // It's a shame you can't just print the array directly like Swift and Python
            string primesDisplay = String.Join(", ", primes);
            Console.WriteLine($"The first {primeCount} primes are {primesDisplay}");

            // What to do with the primes though?

            if(args.Length > 1 && args[1] == "-csv")
            {
                outputGenerator = new CsvSaver();
            }
            else
            {    
                outputGenerator = new GridRender();
            }
            outputGenerator.Output(primes);
        }
    }
}
