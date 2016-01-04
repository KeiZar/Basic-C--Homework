using System;

namespace _09.Exchange_Variable_Values
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {

            int a = 5;
            int b = 10;
            int c;
            
            Console.WriteLine("Before:\na = {0}\nb = {1}", a, b);

            c = a;
            a = b;
            b = c;
            
            Console.WriteLine("After:\na = {0}\nb = {1}", a , b);


        }
    }
}
