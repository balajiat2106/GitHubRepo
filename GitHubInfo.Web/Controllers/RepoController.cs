using System.Web.Mvc;
using GitHubInfo.Services;

namespace GitHubInfo.Web.Controllers
{
    public class RepoController : Controller
    {
        public ActionResult GitHubRepoInfo(string repoUrl)
        {
            //In case of no repository created by the user, return a blank partial view
            if (string.IsNullOrEmpty(repoUrl)) return PartialView();

            IRepoInfoService repoInfo = new RepoInfoService();
            return PartialView("GitHubRepoInfo", repoInfo.GetRepoInfo(repoUrl));
        }
    }
}