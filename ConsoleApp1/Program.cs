using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleBankingApp
{
    class Bank
    {
        static bool WelcomeToApp = true;
        static List<Accounts> accounts = new List<Accounts>();
        class Accounts
        {
            public string firstName;
            public string lastName;
            public string email;
            public string password;
            public decimal Balance;

        }
        static void Main(string[] args)
        {


            while (WelcomeToApp)
            {
                Console.WriteLine("Select an option: ");
                int selectedOption = Convert.ToInt32(Console.ReadLine());

                if (selectedOption == 1)
                {
                    // run register''6
                    Register();
                }
                else if (selectedOption == 2)
                {
                    // run Login
                    Login();
                }
                else if (selectedOption == 3)
                {
                    // Logout
                    WelcomeToApp = false;
                }
                else
                {
                    ShowWelcomeMenu();
                }
            }
        }

        static void ShowWelcomeMenu()
        {
            Console.WriteLine("Welcome to Vic's bank");
            Console.WriteLine("");
            Console.WriteLine("==========================");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Login");
            Console.WriteLine("3. Logout");
            Console.WriteLine("==========================");
        }
        static void Register()
        {
            Console.WriteLine("Welcome to the Register page!");
            Console.WriteLine("==========================");

            Console.WriteLine("1. Fristname: ");
            string firstname = Console.ReadLine();

            Console.WriteLine("2. Lastname: ");
            string lastname = Console.ReadLine();

            Console.WriteLine("3. Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("4. Email: ");
            string password = Console.ReadLine();

            Console.WriteLine("5. Initial Deposit: ");
            decimal initialDeposit = Convert.ToDecimal(Console.ReadLine());

            Accounts newUser = new Accounts
            {
                firstName = firstname,
                lastName = lastname,
                email = email,
                password = password,
                Balance = initialDeposit
            };

            accounts.Add(newUser);
            Console.WriteLine("Congratulations! ");
        }

        static void Login()
        {
            Console.WriteLine("Welcome to the Login page!");

            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();


        }


        static void ShowDashboard()
        {
            //here
        }
        static void Deposit()
        {
            //here
        }
        static void Withdraw()
        {
            // here
        }
        static void CheckBalance()
        {
            //here
        }
    }
}