using System;

namespace _06.Print_a_Sequence
{
    class Program
    {
        static void Main()
        {
            int startIndex = 2;
            int negativeIndex;
            bool isNegative = false;
            int counter = 10;

            for (int i = 0; i < counter; i++)
            {
                if (isNegative == false)
                {
                    Console.WriteLine(startIndex);
                    isNegative = true;
                }
                else if (isNegative)
                {
                    negativeIndex = startIndex * -1;
                    Console.WriteLine(negativeIndex);
                    isNegative = false;
                }
                startIndex++;
            }
        }
    }
}
