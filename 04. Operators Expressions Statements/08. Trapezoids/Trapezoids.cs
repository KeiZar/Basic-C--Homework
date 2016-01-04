using System;

namespace _08.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            //Accidentally skiped "Prime number check" problem so order number is mixed
            Console.WriteLine("Enter a side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b)/ 2) * h;
            Console.WriteLine(area);

        }
    }
}
