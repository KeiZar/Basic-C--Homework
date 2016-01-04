using System;

namespace _06.Four_Digit_Number
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a four digit number(It must NOT start with a zero!)");
            int number = int.Parse(Console.ReadLine());

            if (number > 9999 || number < 1000)
            {
                Console.WriteLine("The number must be exactly 4 digits and cannot start with 0!");
            }

            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;
            int sum = a + b + c + d;

            Console.WriteLine("Sum of the digits is {0}.", sum);
            Console.WriteLine("Reversed: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit first: {0}{1}{2}{3}", d,a,b,c);
            Console.WriteLine("Second and third digits swaped: {0}{1}{2}{3}", a, c, b, d);




        }
    }
}
