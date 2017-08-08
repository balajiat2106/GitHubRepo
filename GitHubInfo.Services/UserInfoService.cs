using Newtonsoft.Json;

namespace GitHubInfo.Services
{
    public class UserInfoService:IUserInfoService
    {
        readonly CommonService _commonService = new CommonService();

        private string SearchUserName { get; set; }

        public UserInfoService(string userName)
        {
            SearchUserName = userName;
        }

        /// <summary>
        /// This service will provide all the basic information about a GitHub user. As per requirement, only few information were shown in the UI
        /// </summary>
        /// <returns>Basic information about a GitHub user</returns>
        public DataModels.Info GetUserInfo()
        {
            string jsonResult = _commonService.GetJson(GitHubUrls.GitHubApiUserUrl + SearchUserName);

            //Handle null reference exception
            if(string.IsNullOrEmpty(jsonResult)) return null;
            DataModels.Info userInfo = JsonConvert.DeserializeObject<DataModels.Info>(jsonResult);
            return userInfo;
        }
    }
}
