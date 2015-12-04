using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SendInBlue.Tests.Services.List
{
    [TestClass]
    public class UserServiceTest
    {
        [TestMethod]
        public void UserService_Create()
        {
            var options = new UserCreateUpdateOptions()
            {
                Email = "johndoe@live.com"
            };

            var response = UserService.Create(options);

            Assert.IsTrue(response.Data.Id > 0);
        }

        [TestMethod]
        public void UserService_Get()
        {
            var options = new UserGetOptions()
            {
                Email = "johndoe@live.com"
            };

            var response = UserService.Get(options);

            Assert.IsTrue(response.Data.Email == "johndoe@live.com");
        }
    }
}
