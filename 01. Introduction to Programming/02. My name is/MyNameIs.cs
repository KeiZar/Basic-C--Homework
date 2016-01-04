using System;

namespace _02.My_name_is
{
    class MyNameIs
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string inputName = Console.ReadLine();
            Console.WriteLine("Hello {0}, my name is Dimitar!", inputName);
        }
    }
}
