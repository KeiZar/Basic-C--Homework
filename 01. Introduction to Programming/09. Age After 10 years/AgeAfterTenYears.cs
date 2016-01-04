using System;

namespace _09.Age_After_10_years
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you Birthday in format 1999/12/31:");
            DateTime birthDay = DateTime.Parse(Console.ReadLine());
            int currentAge = DateTime.Now.Year - birthDay.Year;
            Console.WriteLine("Your current age is: {0}", currentAge);
            Console.WriteLine("You age after 10 years is gonna be {0}", currentAge + 10);
        }
    }
}
