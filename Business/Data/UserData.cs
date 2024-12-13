using Business.Interfaces;
using Business.Models;
using Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Business.Tests")]
namespace Business.Data
{
    internal class UserData : IUserData
    {
        // Instantiation of a static list with UserModel model, to be used for storing the users.
        public static List<UserModel> UserList = new();

        // Method to add a user to the list, with the parameter.
        public string AddToList(UserModel user)
        {
            try
            {
                // Add the parameter user to the list.
                UserList.Add(user);
                return "User added";
            }
            catch (Exception)
            {
                throw new Exception("Adding a user didnt work.");
            }
        }
        // Method that returns a safe list version of the users.
        public List<UserModelSafe> GetSafeList()
        {
            try
            {
                // A list with the model is instantiated.
                List<UserModelSafe> UserListNamePassword = new();
                // A loop that goes through the list, and creates a "safe" model version for each item, and adds it to the "safe" list.
                foreach (UserModel item in UserList)
                {
                    UserModelSafe model = new();
                    model.Name = item.Name;
                    model.Email = item.Email;
                    UserListNamePassword.Add(model);
                }
                return UserListNamePassword;
            }
            catch (Exception)
            {
                throw new Exception("Getting the list didnt work.");
            }
        }
        // Returns the user list (used when saving the json).
        public List<UserModel> GetList()
        {
            try
            {
                return UserList;
            }
            catch (Exception)
            {
                throw new Exception("Returning the list didnt work.");
            }

        }
        // Replaces the user list with the list parameter (used when laoding the json at start)
        public string LoadList(List<UserModel> list)
        {
            UserList = list;
            return "Success";
        }
    }
}
