﻿using System;

namespace _03.Check_for_a_Play_Card
{
    class CheckForPlayCard
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input == "2" || input == "3" || input == "4" || input == "5" ||input == "6"||input == "7" ||
                input == "8" || input == "9" || input == "10" || input == "J"|| input == "Q" || input == "K")
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
