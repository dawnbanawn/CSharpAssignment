using Business.Data;
using Business.Interfaces;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("Business.Tests")]

namespace Business.Services
{
    public class UserCRUD : IUserCRUD
    {

        IUserData userData = new UserData();
        // A method to create a user, with parameters.
        public UserModel AddUser(string name, string email, string password)
        {
            try
            {
                // Instantiate model with the parameters, and also creates a guid id.
                UserModel model = new()
                {
                    Id = Guid.NewGuid(),
                    Name = name,
                    Email = email,
                    Password = password
                };
                // Calls method to send the model to the class handling the "database" (the list).
                userData.AddToList(model);
                return model;
            }
            catch (Exception)
            {
                throw new Exception("Adding a user to the list didnt work.");
            }
        }
        // Method for getting the list with "safer" model (no id/password), from the data class.
        public List<UserModelSafe> GetSafeList()
        {
            try
            {
                return userData.GetSafeList();
            }
            catch (Exception)
            {
                throw new Exception("Getting user list didnt work.");
            }
        }




    }
}
