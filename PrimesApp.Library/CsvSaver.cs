using System;
using System.Collections;
using System.Text;
using System.IO;
using System.Linq;

namespace PrimesApp.Library
{
    public class CsvSaver : IPrimeOutput
    {

        public CsvSaver()
        {

        }

        public string Output(int[] primes)
        {
            Console.WriteLine("Preparing to output the primes to a CSV file");
            string filePath = $"./csv-files/{primes.Length}x{primes.Length}-csv.csv";

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // Just like the grid, lets write the first line on it's own before doing the rest.
                // String.Join is super useful.
                var topRow = "0," + String.Join(",", primes);
                writer.WriteLine(topRow);


                // Then write all the rows below it. 
                for (int i = 0; i < primes.Length; i++)
                {
                    int rowTitle = primes[i];
                    // Insert the "row name" 
                    writer.Write($"{rowTitle},");

                    // I love LINQ so much.
                    int[] multiples = primes.Select(r => r * rowTitle).ToArray();

                    string row = String.Join(",", multiples);
                    writer.WriteLine(row);
                }
                Console.WriteLine($"Your new CSV file can be found at {filePath}");
                return "";
            }
        }
    }
}