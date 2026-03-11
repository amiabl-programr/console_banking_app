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
                            whileLoggedIn = false;
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
            Console.WriteLine("=====================");
            Console.WriteLine("Welcome to your dashboard");
            Console.WriteLine("=====================");

            Console.WriteLine("Welcome");
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            //Console.WriteLine("4. Transfer");
            //Console.WriteLine("5. Transaction history");
            Console.WriteLine("6. Logout");
            Console.WriteLine();
            Console.Write("Select an option: ");
        }
        static void Deposit()
        {
            Console.WriteLine("--- Deposit Money ---");
            Console.Write("Enter amount to deposit: ");
            int amount;
            //int amount = Convert.ToInt32(Console.ReadLine());

            foreach(var acc in accounts)
            {
                if (int.TryParse(Console.ReadLine(), out amount) && amount > 0)
                {
                    acc.Balance += amount;
                    Console.WriteLine("Deposit Successful");
                    Console.WriteLine($"New Balance: {acc.Balance}");
                }
                else
                {
                    Console.WriteLine("Enter a valid amount");
                }
            }

            
        }
        static void Withdraw()
        {
            // here
         }
        static void CheckBalance()
        {
            foreach (var account in accounts)
            {
                Console.WriteLine($"Your current balance is {account.Balance}");
                Console.WriteLine();
                Console.WriteLine("Press any key to return to the menu...");
                string reuturnToMenu = Console.ReadLine();

                if (!string.IsNullOrEmpty(reuturnToMenu))
                {
                    ShowDashboard();
                }
                else
                {
                    Console.WriteLine("Press any key to return to the menu!");
                }
            }
        }
    }
}