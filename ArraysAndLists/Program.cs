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
            var myArray = new int[]{ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    evens.Add(i);
                }
            }
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    odds.Add(i);
                }
            }

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
            Console.WriteLine("Below is a list of all the odd numbers between 0 and 100");
            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine(odds[i]);
            }
            Console.WriteLine("Next is the list of all the even numbers between 0 and 100");
            //foreach (int i in evens)
            //{
            //    Console.WriteLine(i);
            //}
            for (int num = 0; num < evens.Count; num++) 
            Console.WriteLine(evens[num]);
        }
    }
}
