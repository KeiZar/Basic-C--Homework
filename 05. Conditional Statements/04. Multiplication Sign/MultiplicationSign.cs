﻿using System;

namespace _04.Multiplication_Sign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a * b * c > 0)
            {
                Console.WriteLine("+");
            }
            else if (a * b * c == 0)
            {
                Console.WriteLine("0");
            }
            else if (a * b * c < 0)
            {
                Console.WriteLine("-");
            }


        }
    }
}
