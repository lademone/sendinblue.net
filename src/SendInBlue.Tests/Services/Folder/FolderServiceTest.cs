using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SendInBlue.Tests.Services.Folder
{
    [TestClass]
    public class FolderServiceTest
    {
        [TestMethod]
        public void FolderService_CRUD()
        {
            var createOptions = new FolderCreateOptions()
            {
                Name = "test-" + Guid.NewGuid().ToString()
            };

            var createResponse = FolderService.Create(createOptions);

            Assert.IsTrue(createResponse.Code == ResponseTypes.Success);
            Assert.IsTrue(createResponse.Data.Id > 0);

            int folderId = createResponse.Data.Id;

            var updateOptions = new FolderUpdateOptions()
            {
                Name = createOptions.Name + "-1"
            };

            var updateResponse = FolderService.Update(folderId, updateOptions);

            Assert.IsTrue(updateResponse.Code == ResponseTypes.Success);

            var deleteResponse = FolderService.Delete(folderId);

            Assert.IsTrue(deleteResponse.Code == ResponseTypes.Success);
        }
    }
}
