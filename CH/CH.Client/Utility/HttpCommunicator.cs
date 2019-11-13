using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;

namespace CH.Client.Utility
{
    public class HttpCommunicator
	{
		// TODO XML파일로 빼기
		private const string HOST = "localhost";
        private const string PORT = "44379";
		private string apiURI = string.Format("https://{0}:{1}/api", HOST, PORT);

		public T Get<T>(string controllerName, string functionName, object param)
		{
			string uri = string.Format("{0}/{1}/{2}", apiURI, controllerName, functionName);

			return Get<T>(uri).Result;
		}

		/// <summary>
		/// 
		/// </summary>
		private async Task<T> Get<T>(string uri)
		{
			T result;
			HttpClient httpClient = new HttpClient();

			HttpResponseMessage responseMessage = await httpClient.GetAsync(uri);
			responseMessage.EnsureSuccessStatusCode();
			result = (T)JsonConvert.DeserializeObject(await responseMessage.Content.ReadAsStringAsync().ConfigureAwait(false));

			httpClient.Dispose();

			return result;
        }
    }
}
