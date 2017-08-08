using System.Web.Mvc;
using GitHubInfo.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GitHubInfo.Test
{
    [TestClass]
    public class RepoControllerTest
    {
        [TestMethod]
        public void GitHubRepoInfoTest()
        {
            var searchUser = "https://api.github.com/users/robconery/repos";
            var repoController = new RepoController();

            //Act
            ActionResult result = repoController.GitHubRepoInfo(searchUser);

            //Assert
            Assert.IsInstanceOfType(result, typeof(PartialViewResult));

            //Verify the result model type
            ViewResult vResult = result as ViewResult;
            if (vResult != null) Assert.IsInstanceOfType(vResult.Model, typeof(DataModels.Repo));
        }
    }
}
