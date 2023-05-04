using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingExercise
{
    internal class Class1
    {
        public Class1()
        {
            char[] arr = { '1', '2', '3', '4', '5', '6', 't', 'r', 'g' };
            List<int> numbers = new List<int>();
            string str = "";

            foreach (char c in arr)
            {
                try
                {
                    int num = int.Parse(c.ToString());
                    numbers.Add(num);
                    str += c;
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to Parse '{c}'");
                }
            }

            foreach (char c in arr)
            {
                try
                {
                    int num = int.Parse(c.ToString());
                    numbers.Add(num);
                }
                catch (FormatException)
                {
                    // If the character cannot be parsed as an int, do nothing
                }
            }
            // Print the resulting list and string for verification
            Console.WriteLine("Numbers: " + string.Join(",", numbers));
            Console.WriteLine("String: " + str);
        }
    }
}
