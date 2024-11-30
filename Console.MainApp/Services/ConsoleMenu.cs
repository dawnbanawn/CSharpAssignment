using Business.Models;
using Business.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Services
{
    internal class ConsoleMenu
    {
        public void Menu()
        {
            string choice = "";

            UserCRUD userCRUD = new UserCRUD();
            Console.WriteLine("Welcome to the menu!:");
            Console.WriteLine("Press 'a' to add a user, 's' to show all users, or 'x' to exit.");
            while (!choice.Equals("x", StringComparison.CurrentCultureIgnoreCase))
            {
                // Create a string variable and get user input from the keyboard and store it in the variable
                choice = Console.ReadKey().KeyChar.ToString();
                switch (choice)
                {
                    case "a":
                        Console.WriteLine();
                        Console.WriteLine("Adding a user ...");
                        Console.WriteLine("Name: ");
                        string name = Console.ReadLine().ToString();
                        Console.WriteLine("email: ");
                        string email = Console.ReadLine().ToString();
                        Console.WriteLine("password: ");
                        string password = Console.ReadLine().ToString();
                        var bloo = userCRUD.AddUser(name, email, password);
                        if (bloo != null)
                        {
                            Console.WriteLine("User added!");
                        }
                        break;
                    case "s":
                        Console.WriteLine();
                        Console.WriteLine("Showing all users ...");
                        List<UserModelSafe> UserList = userCRUD.GetList();
                        int count = 0;
                        foreach (UserModelSafe UserModel in UserList)
                        {
                            count++;
                            Console.WriteLine("User number " + count);
                            Console.WriteLine("Name: "+ UserModel.Name);
                            Console.WriteLine("Email: " + UserModel.Email); 
                        }
                        break;
                    case "x":
                        Console.WriteLine();
                        Console.WriteLine("Exiting the program ...");
                        Environment.Exit(0);
                        break;
                    default:
                        choice = "";
                        break;
                }
            }


        }


    }
}
