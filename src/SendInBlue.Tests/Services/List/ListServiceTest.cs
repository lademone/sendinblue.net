using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SendInBlue.Tests.Services.List
{
    [TestClass]
    public class ListServiceTest
    {
        public const int FOLDER_ID = 8;
        public const string USER = "johndoe@live.com";

        [TestMethod]
        public void ListService_CRUD_All()
        {
            var createOptions = new ListCreateOptions()
            {
                Name = "Test" + Guid.NewGuid().ToString(),
                Parent = FOLDER_ID
            };

            var createResponse = ListService.Create(createOptions);

            Assert.IsTrue(createResponse.Code == ResponseTypes.Success);

            int listId = createResponse.Data.Id;

            var updateOptions = new ListCreateOptions()
            {
                Name = createOptions.Name + "-1",
                Parent = FOLDER_ID
            };

            var updateResponse = ListService.Update(listId, updateOptions);

            Assert.IsTrue(updateResponse.Code == ResponseTypes.Success);

            var addUseroptions = new ListAddUserOptions()
            {
                Users = new List<string>() { USER }
            };

            var addUserResponse = ListService.AddUser(listId, addUseroptions);

            Assert.IsTrue(addUserResponse.Code == ResponseTypes.Success);

            var deleteUserOptions = new ListDeleteUserOptions()
            {
                Users = new List<string>() { USER }
            };

            var deleteUserResponse = ListService.DeleteUser(listId, deleteUserOptions);

            Assert.IsTrue(deleteUserResponse.Code == ResponseTypes.Success);

            var deleteResponse = ListService.Delete(listId);

            Assert.IsTrue(deleteResponse.Code == ResponseTypes.Success);
        }
    }
}
