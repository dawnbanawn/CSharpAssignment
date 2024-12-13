using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Business.Data;
using Business.Interfaces;
using Business.Models;
namespace Business.Tests.Data
{
    public class UserData_Tests


    {
        IUserData userData = new UserData();

        [Fact]
        public void AddToList_shouldReturnString()
        {
            // arrange
            UserModel user = new()
            {
                Id = Guid.NewGuid(),
                Name = "name",
                Email = "email",
                Password = "password"
            };

            // act
            string answer = userData.AddToList(user);

            // assert
            Assert.Equal("User added", answer);
            Assert.False(string.IsNullOrEmpty(answer));
        }
        [Fact]
        public void GetSafeList_shouldReturnSafeList()
        {
            // arrange
            List<UserModelSafe> safeList = new();

            // act
            safeList = userData.GetSafeList();

            // assert
            Assert.IsType<List<UserModelSafe>>(safeList);
        }
        [Fact]
        public void GetList_shouldReturnList()
        {
            // arrange
            List<UserModel> List = new();

            // act
            List = userData.GetList();

            // assert
            Assert.IsType<List<UserModel>>(List);
        }
    }
}
