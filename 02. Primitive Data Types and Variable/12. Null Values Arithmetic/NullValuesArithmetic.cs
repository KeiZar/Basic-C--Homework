using System;

namespace _12.Null_Values_Arithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? a = null;
            double? b = null;
            Console.WriteLine("{0}, {1}", a, b);
            //Result is the same all around with null

            a += 10;
            b += 10;
            Console.WriteLine("{0}, {1}", a, b);

    }
}
}
