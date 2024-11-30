using Business.Models;
using Business.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business.Data
{
    internal class UserData
    {
        List<UserModel> UserList = new() { };
        List<UserModelSafe> UserListNamePassword = new();



        public string AddToList(UserModel user)
        {
            try
            {
                UserList.Add(user);
                return "User added";
            }
            catch (Exception)
            {
                throw new Exception("Ading a user didnt work.");
            }
        }

        public List<UserModelSafe> GetList()
        {
            try
            {
                List<UserModelSafe> UserListNamePassword = new();
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
    }
}
