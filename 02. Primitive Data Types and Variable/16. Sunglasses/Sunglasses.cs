using System;

namespace _16.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < input; i++)
            {
                if (i == 0 || i == input - 1)
                {
                    Console.WriteLine("{0}{1}{0}", new string('*', input * 2), new string(' ', input));
                }
                else
                {
                    if (i == input / 2)
                    {
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('/', input * 2 - 2),
                            new string('|', input));
                    }
                    else
                    {
                        Console.WriteLine("{0}{1}{0}{2}{0}{1}{0}", new string('*', 1), new string('/', input * 2 - 2),
                            new string(' ', input));
                    }
                }
            }
        }
    }
}
