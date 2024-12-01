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
        
        UserData userData = new UserData();
        public UserModel AddUser(string name, string email, string password)
        {
            try
            {
                UserModel model = new();
                model.Id = Guid.NewGuid();
                model.Name = name;
                model.Email = email;
                model.Password = password;
                userData.AddToList(model);
                return model;
            }
            catch (Exception)
            {
                throw new Exception("Ading a user didnt work.");
            }
        }
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
