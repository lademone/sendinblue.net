using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SendInBlue.Tests.Services.User
{
    [TestClass]
    public class UserServiceTest
    {
        public const string USER = "johndoe@live.com";

        [TestMethod]
        public void UserService_CRUD()
        {
            var createOptions = new UserCreateUpdateOptions()
            {
                Email = USER
            };

            var createResponse = UserService.Create(createOptions);

            Assert.IsTrue(createResponse.Data.Id > 0);

            var getOptions = new UserGetOptions()
            {
                Email = USER
            };

            var getResponse = UserService.Get(getOptions);

            Assert.IsTrue(getResponse.Data.Email == USER);
        }
    }
}
