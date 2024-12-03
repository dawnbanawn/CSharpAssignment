using Business.Models;

namespace Business.Interfaces
{
    internal interface IUserData
    {
        string AddToList(UserModel user);
        List<UserModel> GetList();
        List<UserModelSafe> GetSafeList();
        string LoadList(List<UserModel> list);
    }
}