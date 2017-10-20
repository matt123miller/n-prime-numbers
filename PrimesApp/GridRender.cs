using System;
using System.Collections;
using System.Text;

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
        // I'll use both and compare the results. https://github.com/dotnet/corefxlab/wiki/System.Text.Formatting
        public string Render(int[] primes){
            Console.WriteLine("Preparing render.....");

            string beginning = "| ";
            string separator = " | ";
            string end = " |";
            // A conservative starting size of Int16, but it could possibly grow to Int32 size if there's enough characters
            var sb = new StringBuilder(Int16.MaxValue, Int32.MaxValue);
            sb.Append("|");
            // sb.Append(beginning);

            // Write the whole top row first
            for (int i = 0; i < primes.Length; i++)
            {
                int column = primes[i];
                // Combine the separator and the relevant number
                string insertion = $"{separator}{column}";
                sb.Append(insertion);
            }
            // Insert an end character then the default line terminator for the environment 
            sb.AppendLine(end);

            // Then write all the grid below it. Now I don't have to worry about that empty square in the top left
            for (int i = 0; i < primes.Length; i++)
            {
                int row = primes[i];
                // Insert the "row name" 
                sb.Append($"{beginning}{row}");

                for (int j = 0; j < primes.Length; j++)
                {
                    int column = primes[j];
                    int multiple = row * column;
                    // Combine the separator and the relevant number
                    string insertion = $"{separator}{multiple}";
                    sb.Append(insertion);
                }
                // Insert an end character then the default line terminator for the environment 
                sb.AppendLine(end);
            }

            string grid = sb.ToString();

            return grid;
        }
    }
}