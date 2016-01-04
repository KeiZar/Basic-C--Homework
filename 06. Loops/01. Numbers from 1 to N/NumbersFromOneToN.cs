using System;

namespace _01.Numbers_from_1_to_N
{
    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {

            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
