using System;

namespace _08.Numbers_from_1_to_n
{
    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
            //This problem is designed to introduce the for loop concept you find on Google. It's just a simple use of the loop that is explained during the lecture.
            Console.WriteLine("How many numbers do you want to be printed?");
            int input = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 0; i < input; i++)
            {
                Console.WriteLine(counter);
                counter++;
            }

            //You can input as a big as a number as int.MaxValue and its gonna do it!
            //Its gonna take some time to print out every number from 1 to 2,147,483,647, so to stop the console during the loop press "ctrl + c"
            //Remove the commenting slashes infront of this loop and added commenting slashes on the upper loop.
            //
            //for (int i = 0; i < int.MaxValue; i++)
            //{
            //    Console.WriteLine(counter);
            //    counter++;
            //}
        }
    }
}
