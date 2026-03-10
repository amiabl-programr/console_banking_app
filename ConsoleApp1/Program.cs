using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleBankingApp
{
    class Bank
    {
        static bool WelcomeToApp = true;
       
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

            
        }

        static void Login()
        {
            Console.WriteLine("Welcome to the Login page!");

  


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