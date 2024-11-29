using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Data
{
    internal class UserData
    {
        List<UserModel> UserList = new() { };

        public string AddToList(UserModel user)
        {
            UserList.Add(user);
            return "User added";
        }

        public List<UserModel> GetList()
        {
            return UserList;
        }
    }
}
