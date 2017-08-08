using System.Collections.Generic;

namespace GitHubInfo.Services
{
    public interface IRepoInfoService
    {
        IEnumerable<DataModels.Repo> GetRepoInfo(string repoUrl);
    }
}
