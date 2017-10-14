using System;
using System.Collections;

namespace n_prime_numbers
{
    class GridRender{

        GridRender(){

            Console.WriteLine("Grid renderer");
        }

        public string Render(int[] primes){
            Console.WriteLine("Render");
            // I assume StringBuilder is still in Core?
            return "A nice rendered grid";
        }
    }
}