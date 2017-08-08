using System.ComponentModel;

namespace GitHubInfo.DataModels
{
    public class Info
    {
        [DisplayName("Avatar Url")]
        public string Avatar_Url { get; set; }

        [DisplayName("Login")]
        public string Login { get; set; }

        [DisplayName("Followers")]
        public string Followers { get; set; }

        [DisplayName("Repositories")]
        public string Public_Repos { get; set; }

        [DisplayName("Location")]
        public string Location { get; set; }

        [DisplayName("Username")]
        public string Name { get; set; }

        [DisplayName("Repository Url")]
        public string Repos_Url { get; set; }

        [DisplayName("Bio")]
        public string Bio { get; set; }

        [DisplayName("Gists")]
        public string Public_Gists { get; set; }

    }
}

