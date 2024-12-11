using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
