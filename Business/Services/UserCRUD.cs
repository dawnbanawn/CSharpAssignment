using Business.Data;
using Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class UserCRUD
    {
        private UserModel model = new();
        UserData userData = new UserData();
        public UserModel AddUser(string name, string email, string password)
        {
            model.Name = name;
            model.Email = email;
            model.Password = password;            
            userData.AddToList(model);
            return model;
        }
        public List<UserModel> GetList()
        {
            userData.GetList();
            return userData.GetList();
        }



    }
}
