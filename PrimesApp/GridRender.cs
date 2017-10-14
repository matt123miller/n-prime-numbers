using System;
using System.Collections;

namespace PrimesApp
{
    public class GridRender{

        public GridRender()
        {

        }

        public string Render(int[] primes){
            Console.WriteLine("Render");
            // A string builder is the obvious choice here.
            // I assume it's still in Core?
            return "A nice rendered grid";
        }
    }
}