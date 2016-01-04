using System;

namespace _09.Play_with_Int__Double_and_String
{
    class PlayWithintDoubleString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a type:\n1 --> int\n2 --> double\n3 --> string");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 1:
                    Console.WriteLine("Please enter an int:");
                    input = int.Parse(Console.ReadLine());
                    input = input + 1;
                    Console.WriteLine(input);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double:");
                    double doubleInput = double.Parse(Console.ReadLine());
                    doubleInput += 1;
                    Console.WriteLine(doubleInput);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string:");
                    string stringInput = Console.ReadLine();
                    Console.WriteLine("{0}*", stringInput);
                    break;
            }

        }
    }
}
