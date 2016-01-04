using System;
using System.Collections.Generic;

namespace _02.Print_Company_information
{
    class PrintCompanyInformation
    {
        static void Main(string[] args)
        {
            /* I could use a Dictionary<TKey, TValue>, but that is more complex and looks like so:
             Dictionary<string, string> a = new Dictionary<string, string>(); (well in short)
             So I will be using a simple Console.Readline(); for the strings
             I could also just use a simple List<T>, but that is also advanced stuff and it looks like so:
             List<string> b = new List<string>();
             Use Google or wait until the lecture with the advanced stuff before the exam :)
            */
            
            Console.WriteLine("Please enter the company's name:");
            string companyName = Console.ReadLine();
            if (companyName == string.Empty)
            {
                companyName = "(no company name)";
            }

            Console.WriteLine("Please enter the company's adress:");
            string companyAdress = Console.ReadLine();
            if (companyAdress == string.Empty)
            {
                companyAdress = "(no adress)";
            }

            Console.WriteLine("Please enter the company's phone number (format +359 899 55 55 92):");
            string companyPhone = Console.ReadLine();
            if (companyPhone == string.Empty)
            {
                companyPhone = "(no phone)";
            }

            Console.WriteLine("Please enter the company's fax number(same format as phone number):");
            string companyFax = Console.ReadLine();
            if (companyFax == string.Empty)
            {
                companyFax = "(no fax)";
            }

            Console.WriteLine("Please enter the website of the company:");
            string companyWebsite = Console.ReadLine();
            if (companyWebsite == string.Empty)
            {
                companyWebsite = "(no website)";
            }

            Console.WriteLine("Please enter the Manager's first name:");
            string managerFirstName = Console.ReadLine();
            if (managerFirstName == string.Empty)
            {
                managerFirstName = "(There is no manager in the company!)";
            }

            Console.WriteLine("Please enter the Manager's last name: ");
            string managerLastName = Console.ReadLine();
            if (managerLastName == string.Empty)
            {
                managerLastName = "(There is no manager in the company!)";
            }

            Console.WriteLine("Please enter the age of the Manager:");
            int managerAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Manager's phone number in the format stated above:");
            string managerPhone = Console.ReadLine();
            if (managerPhone == String.Empty)
            {
                managerPhone = "(no phone number)";
            }


            Console.WriteLine("{0}\nAdress: {1}\nTel. {2}\nFax: {3}\nWebsite: {4}\nManager: {5} {6} (Age: {7}, tel: {8})", 
                            companyName, companyAdress, companyPhone, companyFax, companyWebsite, managerFirstName, managerLastName, managerAge, managerPhone);




        }
    }
}
