using System;
using System.ComponentModel;

namespace GitHubInfo.DataModels
{
    public class Repo
    {
        [DisplayName("Repository Name")]
        public string Name { get; set; }

        [DisplayName("Stargazers Count")]
        public int Stargazers_Count { get; set; }

        [DisplayName("Repository URL")]
        public Uri Url { get; set; }
    }
}
