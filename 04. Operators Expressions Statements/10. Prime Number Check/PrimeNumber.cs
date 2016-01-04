using System;

namespace _10.Prime_Number_Check
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            //Accidentaly skiped this problem.
            
            int number = int.Parse(Console.ReadLine());
            
            Console.WriteLine(IsPrime(number));
        }

        static bool IsPrime(int number)
        {
            for (int x = 2; x <= Math.Ceiling(Math.Sqrt(number)); x++)
            {
                if (number > x && number % x == 0)
                    break;
                if (x >= Math.Ceiling(Math.Sqrt(number)) || number == x)
                {
                    return true;
                }
            }
            return false; 
        }
    }
}
