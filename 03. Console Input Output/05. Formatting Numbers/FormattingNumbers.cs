using System;

namespace _05.Formatting_Numbers
{
    class FormattingNumbers
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Number A: ");
            int a = int.Parse(Console.ReadLine());
            string binaryA = Convert.ToString(a, 2);
            Console.WriteLine("Number B: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Number C: ");
            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("Result = |{0,-10:X}|{1,10}|{2,10:F2}|{3,-10:F3}|", a, binaryA.PadLeft(10, '0'), b, c);
        }
    }
}
