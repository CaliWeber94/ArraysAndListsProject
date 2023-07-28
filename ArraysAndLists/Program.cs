using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            var numbers = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            var listevens = new List<int>();
            { }
            
            var listodds = new List<int>();
            { }

            foreach (var number in numbers)
            {
                 if (number % 2 == 0)
                    {

                        listevens.Add(number);
                    }
                

                else
                {
                    listodds.Add(number);

                }
            }

            foreach (var number in listevens)
            
                {
                    Console.WriteLine($"{number}");
                }
            

            foreach (var number in listodds)
            

                {
                    Console.WriteLine($"{number}");
                }
            
            
                /* Create two Lists of type int.
                 * Name one List "evens"
                 * Name the other List "odds"
                 */

                /* Using either a foreach or for loop,
                 * nest an if statement to check to see
                 *  if a number is even or odd.
                 * Then add those numbers to either the evens List
                 * or the odds List
                 */

                /* Now using foreach or for loops,
                 * display each List of even and odd numbers
                 *
                 * Try to be creative in your display
                 */
            
        }
    }
}
