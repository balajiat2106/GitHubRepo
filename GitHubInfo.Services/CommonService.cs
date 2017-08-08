using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;


namespace GitHubInfo.Services
{
    public class CommonService:ICommonService
    {
        public string GetJson(string requestUrl)
        {
            HttpWebRequest webRequest = WebRequest.Create(requestUrl) as HttpWebRequest;

            if (webRequest != null)
            {
                webRequest.Method = "GET";
                webRequest.UserAgent = "GitHubInfo";
                webRequest.Accept = "application/json";
                webRequest.ServicePoint.Expect100Continue = false;

                try
                {
                    using (StreamReader responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
                    {
                        string reader = responseReader.ReadToEnd();
                        return JsonConvert.DeserializeObject(reader).ToString();
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }
    }
}
