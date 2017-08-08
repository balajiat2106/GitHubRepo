using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GitHubInfo.Web.Controllers;

namespace GitHubInfo.Test
{
    [TestClass]
    public class InfoControllerTest
    {
        [TestMethod]
        public void GitHubUserInfoTest()
        {
            //Arrange
            var searchUser = "robconery";
            var infoController = new InfoController();

            //Act
            ActionResult result = infoController.GitHubUserInfo(searchUser);

            //Assert
            Assert.IsInstanceOfType(result, typeof(PartialViewResult));

            //Verify the result model type
            ViewResult vResult = result as ViewResult;
            if (vResult != null) Assert.IsInstanceOfType(vResult.Model, typeof(DataModels.Info));
        }
    }
}
