using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace ConsoleBankingApp
{
    class Bank
    {
        static bool WelcomeToApp = true;
        static List<Account> accounts = new List<Account>();
        
        static void Main(string[] args)
        {
            

            while (WelcomeToApp)
            {
              

                ShowWelcomeMenu();

               
                int selectedOption = Convert.ToInt32(Console.ReadLine());

                if (selectedOption == 1)
                {
                     Register();
                }
                else if (selectedOption == 2)
                {
                    // run Login
                    Login();
                }
                else if (selectedOption == 3)
                {
                   Logout();
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

        static void Logout()
        {
            WelcomeToApp = false;
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

            Console.WriteLine("4. Password: ");
            string password = Console.ReadLine();

            Console.WriteLine("5. Initial Deposit: ");
            decimal initialDeposit = Convert.ToDecimal(Console.ReadLine());

            Account newUser = new Account(firstname, lastname, email, password)
            {
                Balance = initialDeposit
            };

            accounts.Add(newUser);

            Console.WriteLine("Congratulations! ");
        }

        static void Login()
        {
            Console.WriteLine("Welcome to the Login page!");

            Console.Write("Enter your email: ");
            string email = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(email))
            {
                Console.WriteLine("Invalid email input.");
            }

            Console.Write("Enter your password: ");
            string password = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(password))
            {
                Console.WriteLine("Invalid password input.");
            }


            bool whileLoggedIn = true;

            // check if email exists
            foreach (var account in accounts)
            {
                if (email == account.email && password == account.password)
                {
                    Console.WriteLine("Proceed to dashboard");
                    Console.WriteLine();

                    while (whileLoggedIn)
                    {
                        ShowDashboard();
                        int dashboardOptions = Convert.ToInt32(Console.ReadLine());
                        if (dashboardOptions == 1)
                        {
                            CheckBalance();
                        } else if (dashboardOptions == 2)
                        {
                            Deposit();
                        } 
                        else if (dashboardOptions == 3)
                        {
                            Withdraw();
                        } else if (dashboardOptions == 6)
                        {
                            Logout();
                        }
                        else
                        {
                            Console.WriteLine("Choose the right option!");
                        }
                    }
                    
                } else
                {
                    Console.WriteLine("Account not found");
                }
            }

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