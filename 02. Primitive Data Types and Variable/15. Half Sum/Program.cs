using System;
using System.Diagnostics;

namespace _15.Half_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int doubleInput = input * 2;
            int counter = 0;
            int sumOne = 0;
            int sumTwo = 0;

            while (counter < doubleInput)
            {
                int numberInput = int.Parse(Console.ReadLine());
                if (counter >= input)
                {
                    sumTwo += numberInput;
                }
                else
                {
                    sumOne += numberInput;
                }
                counter++;
            }

            if (sumOne == sumTwo)
            {
                Console.WriteLine("Yes, sum={0}", sumOne);
            }
            if (sumOne != sumTwo)
            {
                int diff = sumOne - sumTwo;
                if (diff < 0)
                {
                    diff *= -1;
                }
                Console.WriteLine("No, diff={0}", diff);
            }


        }
    }
}
