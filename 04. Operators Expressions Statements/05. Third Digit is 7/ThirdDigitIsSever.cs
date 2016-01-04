using System;

namespace _05.Third_Digit_is_7
{
    class ThirdDigitIsSever
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int input = int.Parse(Console.ReadLine());

            int thirdDigit = (input / 100) % 10;
            if (thirdDigit == 7)
            {
                Console.WriteLine("Third Digit is Seven!");

            }
            else
            {
                Console.WriteLine("Third digit is not Seven!");
            }
        }
    }
}
