using System.IO;
using System.Net;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CH.Client.Common
{
    public class HttpCommunicator
    {
        private HttpWebRequest request;
        private HttpWebResponse response;
        private const string HOST = "localhost";
        private const string PORT = "44379";

		/// <summary>
		/// 
		/// </summary>
		public Task<T> Get<T>(string controllerName, string functionName, object param)
		{
			string uri = string.Format("http://{0}:{1}/api/{2}/{3}", HOST, PORT, controllerName, functionName);

			request = (HttpWebRequest)WebRequest.Create(uri);
			request.ContentType = "application/json";
			request.Method = Http.Get;
			request.Timeout = 3000;

			response = (HttpWebResponse)request.GetResponse();

			using (StreamReader reader = new StreamReader(response.GetResponseStream()))
			{
				string text = reader.ReadToEnd();
			}

			return null;
        }
    }
}
