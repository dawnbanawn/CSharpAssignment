using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Data;
using Business.Interfaces;
using Business.Models;
using Business.Services;

namespace Business.Tests.Services
{
    public class UserCRUD_Tests
    {
        IUserCRUD userCRUD = new UserCRUD();



        [Fact]
        public void AddUser_ShouldReturnModel()
        {
            // arrange

            // act
            UserModel answer = userCRUD.AddUser("name", "email", "password");

            // assert
            Assert.IsType<UserModel>(answer);

        }
        [Fact]
        public void GetSafeList_shouldReturnSafeList()
        {
            // arrange
            List<UserModelSafe> safeList = new();

            // act
            safeList = userCRUD.GetSafeList();

            // assert
            Assert.IsType<List<UserModelSafe>>(safeList);
        }
    }
}
