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
        public static List<UserModel> UserList = new();



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

        public List<UserModelSafe> GetSafeList()
        {
            Console.WriteLine(UserList.Count + " why this works");

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

        public List<UserModel> GetList()
        {

            Console.WriteLine(UserList.Count +  " wtff");

            try
            {
                return UserList;
            }
            catch (Exception)
            {
                throw new Exception("Returning the list didnt work.");
            }



        }
        public string LoadList(List<UserModel> list)
        {
            UserList = list;
            return "Success";
        }
    }
}
