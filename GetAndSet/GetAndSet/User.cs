using System;
using System.Collections.Generic;
using System.Text;

namespace GetAndSet
{
    public class User
    {

        // THE WHY of Properties

        // Before we had Properties we had to use fields and create 2 methods to read and write data to them

        //public void SetAge(int years)
        //{
        //    Age = years;                     
        //}

        //public void GetAge()
        //{
        //    Console.WriteLine(Age);
        //}


        //Auto Implemented Property --> (code snippet = prop tab tab)
        public int Age { get; set; }
        public string FirstName { get; set; } = "John";
        public string LastName { get; set; }
        public int SSN { get; set; } = 1234567890;
        public int AccountNumber { get; set; } = 000000000;
        public bool ValidUser { get; set; } = false;

        // Full property --> (code snippet = propfull + tab + tab)
        private double _balance;

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public User()
        {

        }

        public User(string firstName, string lastName, int ssn, int accountNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
            AccountNumber = accountNumber;
        }        


    }
}
