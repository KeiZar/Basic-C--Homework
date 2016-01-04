using System;

namespace _06.Quadratic_Equation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            //Problem 6 has a star for higher difficulty
            //Formula "ax^2 + bx + c = 0"
            Console.WriteLine("Please enter \"a\":");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter \"b\": ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter \"c\": ");
            double c = double.Parse(Console.ReadLine());
            double discriminant = 0;
            if (a == 0)
            {
                Console.WriteLine("This is not a quadratic equation!");
                double x = (-c) / b;

            }
            else
            {
                discriminant = (b * b) - 4 * a * c;
            }
            if (discriminant < 0)
            {
                Console.WriteLine("There is no real root!");
            }
            else
            {
                double x1 = ((-b) - Math.Sqrt(discriminant))/(2*a);
                double x2 = ((-b) + Math.Sqrt(discriminant))/(2*a);

                Console.WriteLine("Roots\nx1 = {0}\nx2 = {1}", x1, x2);
            }

        }
    }
}
