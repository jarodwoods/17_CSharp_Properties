using System;

namespace EncapsulationInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var mAcct = new BankAccount(400);
            mAcct.Deposit(30000);
            var bal = mAcct.GetBalance();
            mAcct.Withdraw(300);

            //----------------------------Encapsulation Exercise-----------------------\\



            //----------------------------Properties Exercise--------------------------\\

            var personalInfo = new PersonalInformation();
            Console.WriteLine("Please enter your phone number");
            personalInfo.NumberFormatted = Console.ReadLine();

            Console.WriteLine(personalInfo.NumberFormatted);

        }
    }
}
