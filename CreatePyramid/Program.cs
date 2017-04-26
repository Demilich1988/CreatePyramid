using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatePyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            // This loop goes row by row.
            for (int row = 0; row < 5; row++)
            {
                

                // Prints out the correct number of spaces
                for (int space = 0; space < 5 - row - 1; space++)
                {
                    Console.Write(" ");
                }

                // Prints out the correct number of stars.
                for (int star = 0; star < row * 2 + 1; star++)
                {
                    Console.Write("*");
                }

                // Print this out to move down a line.
                Console.WriteLine();
            }

            // Wait for the user to respond before closing...
            Console.ReadKey();
        }
    }
    }

