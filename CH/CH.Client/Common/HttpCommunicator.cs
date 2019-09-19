using System.Net;
using static System.Net.WebRequestMethods;

namespace CH.Client.Common
{
    public class HttpCommunicator
    {
        private HttpWebRequest request;
        private HttpWebResponse response;
        private const string HOST = "localhost";
        private const string PORT = "8080";

        /// <summary>
        /// 
        /// </summary>
        public DTO<T> Get(string controllerName, string functionName, object param)
        {
            string uri = string.Format("http://{0}:{1}/{2}/{3}", HOST, PORT, controllerName, functionName);

            request = (HttpWebRequest)WebRequest.Create(uri);
            request.ContentType = "application/json";
            request.Method = Http.Get;

            response = (HttpWebResponse)request.GetResponse();

            response.GetResponseStream()
        }
    }
}
