using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH.Client.Views.Common
{
	public partial class BaseForm : Form
	{
		public BaseForm()
		{
			InitializeComponent();
		}

        // TODO XML파일로 빼기
        private const string HOST = "localhost";
        private const string PORT = "44379";
        private readonly string apiURI = string.Format("https://{0}:{1}/api", HOST, PORT);

		public T Get<T>(string controllerName, string functionName, object param)
		{
			string uri = string.Format("{0}/{1}/{2}", apiURI, controllerName, functionName);

			return GetAsync<T>(uri, param).Result;
		}
		public T Post<T>(string controllerName, string functionName, object param)
		{
			string uri = string.Format("{0}/{1}/{2}", apiURI, controllerName, functionName);

			return PostAsync<T>(uri, param).Result;
		}

		private async Task<T> GetAsync<T>(string uri, object param)
		{
			T t = default(T);
			HttpClient client = new HttpClient();
			HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, uri);
			HttpResponseMessage response;
			string jsonParam = JsonConvert.SerializeObject(param);
			client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
			request.Content = new StringContent(jsonParam, Encoding.UTF8, "application/json");
			response = await client.SendAsync(request).ConfigureAwait(false);

			response.EnsureSuccessStatusCode();
			string result = await response.Content.ReadAsStringAsync();

			t = JsonConvert.DeserializeObject<T>(result);

			return t;
		}

		// TODO CRUD共通である関数作成
		/// <summary>
		/// POST要請を行います。
		/// </summary>
		/// <typeparam name="T">指定された任意のタイプ</typeparam>
		/// <param name="uri">URI</param>
		/// <param name="param">渡すパラメータ</param>
		/// <returns>通信返事</returns>
		private async Task<T> PostAsync<T>(string uri, object param)
		{
			T result = default;
			// パラメータ
			string jsonParam = JsonConvert.SerializeObject(param);
			string jsonResult;
			HttpClient client = new HttpClient();
			// メソッド、URI、パラメータセット
			HttpRequestMessage request = new HttpRequestMessage 
			{
				Method = HttpMethod.Post,
				RequestUri = new Uri(uri),
				Content = new StringContent(jsonParam, Encoding.UTF8, "application/json")
			};	
			HttpResponseMessage response;

			// ヘッダーはJSON
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

			// 通信
			response = await client.SendAsync(request).ConfigureAwait(false);

			// 失敗したらThrowします。
			// TODO try catch作成
			response.EnsureSuccessStatusCode();
			// 結果取得
			jsonResult = await response.Content.ReadAsStringAsync();
			// JSONをオブジェクトに変換
			result = JsonConvert.DeserializeObject<T>(jsonResult);

			return result;
		}
	}
}
