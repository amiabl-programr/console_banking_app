using System;

namespace ConsoleBankingApp
{
    public class Account
    {
        public string firstName;
        public string lastName;
        public string email;
        public string password;
        public decimal Balance;  

        public Account (string firstname, string lastName, string email, string password)
        {
            this.firstName = firstname;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.Balance = 0;

        }

        public override string ToString()
        {
            return $"Name: {firstName} {lastName}, Email: {email}, Balance: {Balance}";
        }
    }
}
