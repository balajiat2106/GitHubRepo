namespace GitHubInfo.Services
{
    class GitHubUrls
    {
        public string Username { get; set; }

        internal static string GitHubApiBaseUrl
        {
            get { return "https://api.github.com"; }
        }

        internal static string GitHubApiUserUrl
        {
            get { return "https://api.github.com/users/"; }
        }
    }
}
