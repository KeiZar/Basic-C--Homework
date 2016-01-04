using System;

namespace _05.Square_Root
{
    class SquareRoot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int inputNumber = int.Parse(Console.ReadLine());
            double newNumber = Math.Sqrt(inputNumber);
            Console.WriteLine("The square root of [{0}], is [{1}]!", inputNumber, newNumber);
        }
    }
}
