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
            
            // Instantiate service classes
            UserCRUD userCRUD = new();
            SaveAndLoadUserList _saveAndLoadUserList = new();

            // Calls function to load json, and save the return.
            var loadList = _saveAndLoadUserList.LoadJson();
            // Checks if the function call was successfull.
            if (loadList != null)
            {
                Console.WriteLine("List loaded ...");
            }
            Console.WriteLine("Welcome to the menu!:");
            Console.WriteLine("Press 'a' to add a user, 's' to show all users, or 'x' to exit.");
            // Loop that only ends when program exits.
            while (true)
            {
                // Stores keyboard input in a variable.
                string choice = Console.ReadKey().KeyChar.ToString();
                // Checks and runs code depending on the variable.
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
                        // Calls function to add user, with user info as arguments, and saves/checks the return.
                        var answer = userCRUD.AddUser(name, email, password);
                        if (answer != null)
                        {
                            Console.WriteLine("User added!");
                        }
                        break;
                    case "s":
                        Console.WriteLine();
                        Console.WriteLine("Showing all users ...");
                        // Calls a function that returns a list with models that don´t have ID/password.
                        List<UserModelSafe> UserList = userCRUD.GetSafeList();
                        int count = 0;
                        // For loop that prints all items to the console.
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
                        Console.WriteLine("Saving Json and Exiting the program ...");
                        // Calls method that saves the user list to a json.
                        var saveReturn = _saveAndLoadUserList.SaveJson();
                        Console.WriteLine(saveReturn);
                        // Exists the program.
                        Environment.Exit(0);
                        break;
                    default:
                        break;
                }
            }


        }


    }
}
