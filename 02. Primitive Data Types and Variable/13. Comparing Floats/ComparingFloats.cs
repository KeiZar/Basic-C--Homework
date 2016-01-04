using System;

namespace _13.Comparing_Floats
{
    class ComparingFloats
    {
        static void Main()
        {
            Console.WriteLine("Please input float A:");
            float a = float.Parse(Console.ReadLine());
            if (a < 0)
            {
                a *= -1;
            }

            Console.WriteLine("Please input float B:");
            float b = float.Parse(Console.ReadLine());


            if (b < 0)
            {
                b *= -1;
            }

            float c = (float)0.000001;



            float result = a - b;

            if (result < 0)
            {
                result *= -1;
            }
            if (result == c)
            {
                Console.WriteLine("false");
            }
            if (result > c)
            {
                Console.WriteLine("false");
            }
            if (result < c)
            {
                Console.WriteLine("true");
            }
      
        }
    }
}
