using System;
using System.Security.Cryptography;
using System.Threading;

namespace _10.Employee_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part of our company policy we will ask you some personal information for our employee records.");
            Console.WriteLine("What is your First name?");
            string firstName = Console.ReadLine();
            Console.WriteLine("What is your Last name?");
            string lastName = Console.ReadLine();
            Console.WriteLine("What is your age? [0...100]");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("What is your gender? [m/f]");
            string gender = Console.ReadLine();
            Console.WriteLine("We will now generate a Personal ID number and a Unique employee number.\nPlease wait ~10 seconds.");
            
            long personalIdNumber = 8306112507;
            Random rnd = new Random();
            int uniqueEmployeeNumber = rnd.Next(27560000, 27569999);
            Thread.Sleep(10000);

            Console.WriteLine("This is your employee card:");
            Console.WriteLine("First name: {0}\nLast name: {1}\nAge: {2}\nGender: {3}\nPersonal ID: {4}\nUnique Employee number: {5}", firstName, lastName, age, gender, personalIdNumber, uniqueEmployeeNumber);


        }
    }
}
