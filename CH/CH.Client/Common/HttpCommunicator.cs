using System.Net;

namespace CH.Client.Common
{
    public class HttpCommunicator
    {
        private readonly HttpWebRequest request;

        public HttpCommunicator()
        {
            string uriString = "";

            request = (HttpWebRequest)WebRequest.Create(uriString);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Get(string, )
        {
            request = 
            request.ContentType = "application/json";
            request.Method = "GET";


        }
    }
}
