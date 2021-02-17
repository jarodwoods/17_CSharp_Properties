using System;
using System.Text.RegularExpressions;

namespace GetAndSet
{
    class Program
    {
        static void Main(string[] args)
        {
            var admin = new User();            
            admin.FirstName = "John";

            var User_01 = new User("John", "Ward", 123_456_7890, 1223243323);
            

            //Console.WriteLine($"Hey my name is {User_01.FirstName} {User_01.LastName}. " +
                              //$"My SSN is {User_01.SSN} and my account number {User_01.AccountNumber}."); 

            //Console.WriteLine(admin.Name + guest.FirstName);

            
        }
    }
}
