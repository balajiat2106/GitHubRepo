using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace GitHubInfo.Services
{
    public class RepoInfoService:IRepoInfoService
    {
        readonly CommonService _commonService = new CommonService();
        
        /// <summary>
        /// This service is used to provide repositories for a given url. As part of requirement, repositories with top 5 stargazers count is returned 
        /// </summary>
        /// <param name="repoUrl">Repository URL</param>
        /// <returns>List of repositories</returns>
        public IEnumerable<DataModels.Repo> GetRepoInfo(string repoUrl)
        {
            string jsonResult = _commonService.GetJson(repoUrl);

            //Handle null reference exception
            if (string.IsNullOrEmpty(jsonResult)) return null;
            var repoInfo = JsonConvert.DeserializeObject<IEnumerable<DataModels.Repo>>(jsonResult);

            //Requirement: Return the 5 repositories with highest stargazers count
            return repoInfo.OrderByDescending(t => t.Stargazers_Count).Take(5);
        }
    }
}
