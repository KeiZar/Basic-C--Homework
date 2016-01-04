using System;

namespace _02.Bonus_Score
{
    class BonusScore
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input >= 10 || input <= 0)
            {
                Console.WriteLine("Invalid Score!");
            }
            else
            {
                if (input >= 1 && input <= 3)
                {
                    input *= 10;
                    Console.WriteLine(input);
                }
                if (input >= 4 && input <= 6)
                {
                    input *= 100;
                    Console.WriteLine(input);
                }
                if (input >= 7 && input <= 9)
                {
                    input *= 1000;
                    Console.WriteLine(input);
                }
            }
        }
    }
}
