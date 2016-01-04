using System;

namespace _06.Strings_And_Objects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World!";
            object helloWorld = hello + " " + world;

            string objHelloWorld = helloWorld.ToString();


            Console.WriteLine("The value of the object variable is: " + objHelloWorld);

        }
    }
}
