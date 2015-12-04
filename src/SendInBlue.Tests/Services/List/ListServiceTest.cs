using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SendInBlue.Tests.Services.List
{
    [TestClass]
    public class ListServiceTest
    {
        [TestMethod]
        public void ListService_AddUser()
        {
            var options = new ListAddUserOptions()
            {
                Users = new List<string>() { "johndoe@live.com" }
            };

            var response = ListService.AddUser(5, options);

            Assert.IsTrue(response.Code == ResponseTypes.Success);
        }

        [TestMethod]
        public void ListService_AddUser_Fail()
        {
            var options = new ListAddUserOptions()
            {
                Users = new List<string>() { "johndoe@live.com" }
            };

            var response = ListService.AddUser(Int32.MaxValue, options);

            Assert.IsTrue(response.Code != ResponseTypes.Success);
        }

        [TestMethod]
        public void ListService_DeleteUser_Fail()
        {
            var options = new ListDeleteUserOptions()
            {
                Users = new System.Collections.Generic.List<string>() { "johndoe@live.com" }
            };

            var response = ListService.DeleteUser(Int32.MaxValue, options);

            Assert.IsTrue(response.Code != ResponseTypes.Success);
        }

        [TestMethod]
        public void ListService_DeleteUser()
        {
            var options = new ListDeleteUserOptions()
            {
                Users = new List<string>() { "johndoe@live.com" }
            };

            var response = ListService.DeleteUser(5, options);

            Assert.IsTrue(response.Code != ResponseTypes.Success);
        }
    }
}
