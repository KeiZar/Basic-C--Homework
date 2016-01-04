using System;

namespace _01.Odd_or_Even_Integers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int input = int.Parse(Console.ReadLine());
            

            if ((input & 1) == 0)
            {
                Console.WriteLine("false");
            }
            else
            {
                Console.WriteLine("true");
            }

            // Due to a little complain about not using Console.ReadLine(); at the end of my previous homework
            // I'm suggesting you to use CTRL+F5 that way the program will not close automatically after final input
            // and will show a "Press any key to close program"!
            // It is advisable to get used to using ctrl+F5 because it may happen that the Judge system SoftUni uses
            // hates the "Console.ReadLine();" at the end of the program and may not give full 100 points!


        }
    }
}
