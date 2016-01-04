using System;
using System.Globalization;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter width:");
            double width = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter height:");
            double height = double.Parse(Console.ReadLine());

            double perimeter = 2*(width + height);

            double area = width*height;

            Console.WriteLine("The rectangles perimerter is {0} and area is {1}", perimeter, area);

        }
    }
}
