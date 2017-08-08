using System.Web.Mvc;
using GitHubInfo.Services;

namespace GitHubInfo.Web.Controllers
{
    public class InfoController : Controller
    {
        public ActionResult GitHubUserInfo(string txtSearchName)
        {
            //In case of no input, return a blank view
            if (string.IsNullOrEmpty(txtSearchName)) return View();

            //Pass the search string to the service class
            IUserInfoService userInfo = new UserInfoService(txtSearchName);
            return PartialView("GitHubUserInfo", userInfo.GetUserInfo());
        }

        protected override void OnException(ExceptionContext filterContext)
        {
            filterContext.ExceptionHandled = true;
            string controller = (string)RouteData.Values["controller"];
            string action = (string)RouteData.Values["action"];
            var model = new HandleErrorInfo(filterContext.Exception, controller, action);

            filterContext.Result = new ViewResult
            {
                ViewName = "Error",
                ViewData = new ViewDataDictionary(model)
            };
        }
    }
}