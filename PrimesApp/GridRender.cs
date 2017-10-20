using System;
using System.Collections;

// The application should output an N+1 x N+1 grid of numbers
// Remember I need to generate 20,000+ prime numbers, 
// whatever grid I create won't satisfactorily fit in a terminal window. 
// I could write it to a csv file afterwards so it's atleast viewable?

// Example primes multiplication table when N is 3

// | | 2 | 3 | 5 |

// | 2 | 4 | 6 | 10 |

// | 3 | 6 | 9 | 15 |

// | 5 | 10 | 15 | 25 |

namespace PrimesApp
{
    public class GridRender{

        public GridRender()
        {
            
        }

        // Typically I'd use a StringBuilder in C# because repeatedly appending strings 
        // creates lots of extra memory that has to be collected. But .NET Core, being web favourable, 
        // also offers a new System.Text.Formatting API that allocates even less memory.
        // I'll use both and compare the results.
        public string Render(int[] primes){
            Console.WriteLine("Preparing render.....");

            

            return "A nice rendered grid";
        }
    }
}