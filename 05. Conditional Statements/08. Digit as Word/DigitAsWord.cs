﻿using System;

namespace _08.Digit_as_Word
{
    class DigitAsWord
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if (input != "0" && input != "1" && input != "2" && input != "3" && input != "4" && input != "5" && input != "6" && input != "7" && input != "8" && input != "9")
            {
                Console.WriteLine("not a digit");
            }
            switch (input)
            {
                case "0":
                    Console.WriteLine("zero");
                    break;
                case "1":
                    Console.WriteLine("one");
                    break;
                case "2":
                    Console.WriteLine("two");
                    break;
                case "3":
                    Console.WriteLine("three");
                    break;
                case "4":
                    Console.WriteLine("four");
                    break;
                case "5":
                    Console.WriteLine("five");
                    break;
                case "6":
                    Console.WriteLine("six");
                    break;
                case "7":
                    Console.WriteLine("seven");
                    break;
                case "8":
                    Console.WriteLine("eight");
                    break;
                case "9":
                    Console.WriteLine("nine");
                    break;
                    
            }

        }
    }
}
