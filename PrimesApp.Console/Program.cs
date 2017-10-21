using System;
using PrimesApp.Library;

namespace PrimesAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeCount = 0;

            // A little sanity testing.
            try
            {
                primeCount = Int32.Parse(args[0]);
            }
            catch (FormatException)
            {
                Console.WriteLine($"{args[0]}: Bad Format");
                return;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"{args[0]}: Overflow");
                return;
            }

            if (primeCount < 1)
            {
                Console.WriteLine("Please enter an integer greater than 0");
                return;
            }

            // The required objects
            var primeFinder = new Primes();
            IPrimeOutput outputGenerator;

            int[] primes = primeFinder.FindPrimes(primeCount);
            // It's a shame you can't just print the array directly like Swift and Python
            string primesDisplay = String.Join(", ", primes);
            Console.WriteLine($"The first {primeCount} primes are {primesDisplay}");

            // What to do with the primes though?
            // Coding against an interface really is lovely.
            if (args.Length > 1)
            {
                if (args[1] == "-csv")
                {
                    outputGenerator = new CsvSaver();
                }
                else
                {
                    Console.WriteLine($"The argument {args[1]} cannot be parsed, did you mean -csv ?");
                    return;
                }
            }
            else
            {
                outputGenerator = new GridRender();
            }
            outputGenerator.Output(primes);
        }
    }
}
