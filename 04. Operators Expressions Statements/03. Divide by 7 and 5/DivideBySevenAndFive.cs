using System;

namespace _03.Divide_by_7_and_5
{
    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");

            int input = int.Parse(Console.ReadLine());

           
            if ((input % 5 == 0) && (input % 7 == 0))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}
