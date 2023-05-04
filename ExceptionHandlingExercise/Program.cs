using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ExceptionHandlingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------------------------------------
            // First create an char[], it must contain 6 numbers and 3 letters - name it arr
            char[] arr = "123456abc".ToCharArray();
            // Create a list called numbers that will hold integers
            List<int> numbers = new List<int>();
            List<char> letters = new List<char>();
            // Create an string variable with an empty string initializer - name it str
            string str = "";

            Console.WriteLine(arr);

            // using a foreach loop, attempt to parse the elements in your char[] with int.Parse()
            foreach (char c in arr)
            {
                try
                {
                    int num = int.Parse(c.ToString());
                    numbers.Add(num);
                    str = str + c;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to Parse '{c}'");
                }
                               
            }


            // and Exceptions will be thrown 
            // Below we will set this up 
            // ------------------------------------------------------------------------------



            //TODO START HERE:

            // Make a foreach loop to iterate through your character array

            foreach (char c in arr)
            {
                try
                {
                    char let = char.Parse(c.ToString());
                    letters.Add(let);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to Parse '{c}'");
                }
            }


            // Now create a try catch


            // Inside your try block
            // set your string variable to each array element in your char[] to .ToString()
            // Now, using int.Parse, parse your string variable and store in an int variable
            // Then add each int to your list

            // catch your Exception:
            // in the scope of your catch you can use the following, 

            //Console.WriteLine($"Unable to Parse '{character}'"); //character will be the name of each item in your collection


            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            foreach (char let in letters)
            {
                Console.WriteLine(let);
            }
        }
    }
}
