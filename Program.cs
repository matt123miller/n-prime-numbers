using System;

namespace n_prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var primeFinder = Primes();
            var gridRenderer = GridRender();

            int[] primes = primeFinder.FindPrimes(100);
            string grid = gridRenderer.Render(primes);
            Console.WriteLine(grid);
        }
    }
}
