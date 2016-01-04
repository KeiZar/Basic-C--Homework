using System;
using System.Collections.Generic;

namespace _11.Bank_Account_Data
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            string firstName = "Dimitur";
            string middleName = "Rumenov";
            string lastName = "Cekov";

            int moneyBalance = 100000;
            string currency = "BGN";

            string bankName = "Raifaisen Bank";
            string iban = "BG 13 RBB 100015000";

            long firstCreditCard = 4144881024772477;
            long secondCreditCard = 9899656812147587;
            long thirdCreditCard = 3696454512547896;

            Console.WriteLine("Bank Account Date of {0} {1} {2}\n", firstName, middleName, lastName);
            Console.WriteLine("Current Ballance: {0} {1}\n", moneyBalance, currency);
            Console.WriteLine("Bank name and IBAN: {0}\nIBAN: {1}\n", bankName, iban);
            Console.WriteLine("Credit Card Numbers:\n{0}\n{1}\n{2}\n",firstCreditCard, secondCreditCard, thirdCreditCard);
        }
    }
}
