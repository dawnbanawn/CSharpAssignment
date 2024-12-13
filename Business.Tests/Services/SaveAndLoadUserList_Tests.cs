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
    public class SaveAndLoadUserList_Tests
    {
        ISaveAndLoadUserList _saveAndLoadUserList = new SaveAndLoadUserList();

        [Fact]
        public void SaveJson_shouldReturnString()
        {
            // arrange

            // act
            string answer = _saveAndLoadUserList.SaveJson();

            // assert
            Assert.Equal("Saving the data was successfull.", answer);
        }
        [Fact]
        public void LoadJson_shouldReturnString()
        {
            // arrange

            // act
            string answer = _saveAndLoadUserList.LoadJson();

            // assert
            Assert.Equal("Success", answer);
        }
    }
}
