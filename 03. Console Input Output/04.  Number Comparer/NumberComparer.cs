using System;

namespace _04.Number_Comparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            double b = double.Parse(Console.ReadLine());

            while (a > b)
            {
                Console.WriteLine("{0} is greater!", a);
                break;
            }
            while (b > a)
            {
                Console.WriteLine("{0} is greater!", b);
                break;
            }
        }
    }
}
