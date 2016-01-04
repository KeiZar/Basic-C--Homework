using System;

namespace _03.Circle_Perimeter_and_Area
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the radius of the circle:");
            decimal radius = decimal.Parse(Console.ReadLine());
            decimal perimeter = 2 * (decimal)Math.PI * radius;
            decimal area = (decimal)Math.PI * radius * radius;
            Console.WriteLine("Perimeter: {0:F2}\nArea: {1:F2}", perimeter, area);

        }
    }
}
