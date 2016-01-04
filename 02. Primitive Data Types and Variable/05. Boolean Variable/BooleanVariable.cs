using System;

namespace _05.Boolean_Variable
{
    internal class BooleanVariable
    {
        private static void Main(string[] args)
        {
            bool isFemale = false;

            Console.WriteLine("What is your gender?");
            string gender = Console.ReadLine();

            if (gender == "female")
            {
                isFemale = true;
                Console.WriteLine("Your gender is female, so the boolean variable is {0}", isFemale);
            }
            else
            {
                Console.WriteLine("You gender is male so the boolena varible is {0}", isFemale);
            }
        }
    }
}
