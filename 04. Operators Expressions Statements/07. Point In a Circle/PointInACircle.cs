using System;

namespace _07.Point_In_a_Circle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter coordinate x of the point: ");
            float x = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y of the point: ");
            float y = float.Parse(Console.ReadLine());
            byte rad = 2;
            bool inCircle = x * x + y * y <= rad * rad;
            Console.WriteLine("{0}", inCircle);
        }
    }
}
