using Business.Models;

namespace Business.Interfaces
{
    public interface IUserCRUD
    {
        UserModel AddUser(string name, string email, string password);
        List<UserModelSafe> GetSafeList();
    }
}