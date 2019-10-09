using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace CH.Client.Common
{
    public class HttpCommunicator
    {
        private HttpWebRequest request;
        private HttpWebResponse response;
        private const string HOST = "127.0.0.1";
        private const string PORT = "44379";




		/// <summary>
		/// 
		/// </summary>
		public async Task Get(string controllerName, string functionName, object param)
		{
			string uri = string.Format("https://api.warframestat.us/pc/alerts");

			HttpClient client = new HttpClient();
			HttpResponseMessage responseMessage = await client.GetAsync(uri);
			responseMessage.EnsureSuccessStatusCode();
			string result = await responseMessage.Content.ReadAsStringAsync();
			Console.WriteLine(result);
        }
    }
}
