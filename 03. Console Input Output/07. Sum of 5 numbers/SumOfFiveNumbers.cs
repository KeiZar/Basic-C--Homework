using System;
using System.Linq;

namespace _07.Sum_of_5_numbers
{
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            /*
            Problem uses a string array (string[]) that can hold multiple strings on just 1 line. 
            To manipulate the strings in the array, you can use indexer(almost the same as a placeholder) represented as [0.....1000],
            depending on how many strings are added into the array.

            For a better explanation, wait for the last lecture about advanced tools and topics thats before the exam.
            */
            Console.WriteLine("Please enter 5 numbers on a single line: ");
            string[] input = Console.ReadLine().Split();

            double a = double.Parse(input[0]);
            double b = double.Parse(input[1]);
            double c = double.Parse(input[2]);
            double d = double.Parse(input[3]);
            double e = double.Parse(input[4]);

            double summary = a + b + c + d + e;

            Console.WriteLine(summary);
        }
    }
}
