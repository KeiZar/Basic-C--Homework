using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Gravitation_on_the_Moon
{
    class GravitationOnTheMoon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your weight on Earth?");

            double input = double.Parse(Console.ReadLine());

            double weightOnMoon = input * 0.17;

            Console.WriteLine("Your weight on the Moon will be {0}.", weightOnMoon);

        }
    }
}
