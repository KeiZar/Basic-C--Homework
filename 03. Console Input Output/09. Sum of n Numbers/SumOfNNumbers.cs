using System;
using System.Linq;

namespace _09.Sum_of_n_Numbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            //Problem uses an array of double and a for loop. After the for-loop is finished the code on line 20 uses LINQ to sumarize every number in the array.
            Console.WriteLine("How many numbers do you want to be calculated?");
            int input = int.Parse(Console.ReadLine());

            double[] numbersToBeCalculated = new double[input];

            for (int i = 0; i < input; i++)
            {
                numbersToBeCalculated[i] = double.Parse(Console.ReadLine());
            }
            double calculatedNumbers = numbersToBeCalculated.Sum();

            Console.WriteLine(calculatedNumbers);
        }
    }
}
