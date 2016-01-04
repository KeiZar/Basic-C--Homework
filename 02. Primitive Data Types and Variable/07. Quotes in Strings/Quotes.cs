using System;
using System.Net.Configuration;

namespace _07.Quotes_in_Strings
{
    class Quotes
    {
        static void Main(string[] args)
        {
            //Using the escape method with \ to add the quotation marks.
            string tiltedEscape = "The \"use\" of quotations causes difficulties.";


            //Using the all-escape method with @
            string allEscape = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(tiltedEscape + "\n" + allEscape);

        }
    }
}
