using System;

namespace _10.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci sequence is Xn = Xn-1 + Xn-2.
            Console.WriteLine("How many possitions do you want to see?");
            int input = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 0;
            int c;
            
            for (int i = 0; i < input; i++)
            {
                Console.Write(b + " ");
                c = a + b;
                b = a;
                a = c;
            }


        }
    }
}
