using Newtonsoft.Json;
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
        private const string HOST = "localhost";
        private const string PORT = "44379";

		/// <summary>
		/// 
		/// </summary>
		public async Task<T> Get<T>(string controllerName, string functionName, object param = null)
		{
			T result;
			string uri = string.Format("https://{0}:{1}/api/{2}/{3}", HOST, PORT, controllerName, functionName, param);

			HttpClient httpClient = new HttpClient();

			HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);
			responseMessage.EnsureSuccessStatusCode();
			result = (T)JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false));

			httpClient.Dispose();

			return result;
        }
    }
}
