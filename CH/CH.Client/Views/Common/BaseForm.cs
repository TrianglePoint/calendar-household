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

		/// <summary>
		/// GET要請を行います。
		/// </summary>
		/// <typeparam name="T">指定された任意のタイプ</typeparam>
		/// <param name="controllerName">コントローラー名</param>
		/// <param name="functionName">メソッド名</param>
		/// <param name="param">渡すパラメータ</param>
		/// <returns>通信返事</returns>
		public T Get<T>(string controllerName, string functionName, object param)
		{
			return GetAsync<T>(CreateURI(controllerName, functionName), param).Result;
		}

		/// <summary>
		/// POST要請を行います。
		/// </summary>
		/// <typeparam name="T">指定された任意のタイプ</typeparam>
		/// <param name="controllerName">コントローラー名</param>
		/// <param name="functionName">メソッド名</param>
		/// <param name="param">渡すパラメータ</param>
		/// <returns>通信返事</returns>
		public T Post<T>(string controllerName, string functionName, object param)
		{
			return RequestAsync<T>(HttpMethod.Post, CreateURI(controllerName, functionName), param).Result;
		}

		/// <summary>
		/// PUT要請を行います。
		/// </summary>
		/// <typeparam name="T">指定された任意のタイプ</typeparam>
		/// <param name="controllerName">コントローラー名</param>
		/// <param name="functionName">メソッド名</param>
		/// <param name="param">渡すパラメータ</param>
		/// <returns>通信返事</returns>
		public T Put<T>(string controllerName, string functionName, object param)
		{
			return RequestAsync<T>(HttpMethod.Put, CreateURI(controllerName, functionName), param).Result;
		}

		/// <summary>
		/// DELETE要請を行います。
		/// </summary>
		/// <typeparam name="T">指定された任意のタイプ</typeparam>
		/// <param name="controllerName">コントローラー名</param>
		/// <param name="functionName">メソッド名</param>
		/// <param name="param">渡すパラメータ</param>
		/// <returns>通信返事</returns>
		public T Delete<T>(string controllerName, string functionName, object param)
		{
			return RequestAsync<T>(HttpMethod.Delete, CreateURI(controllerName, functionName), param).Result;
		}

		/// <summary>
		/// URIを生成します。
		/// </summary>
		/// <param name="controllerName">コントローラー名</param>
		/// <param name="functionName">メソッド名</param>
		/// <returns>URI</returns>
		private string CreateURI(string controllerName, string functionName)
		{
			// TODO XML파일로 빼기
			string host = "localhost";
			string port = "44379";
			string baseURI = string.Format("https://{0}:{1}/api", host, port);

			return string.Format("{0}/{1}/{2}", baseURI, controllerName, functionName);
		}

		// TODO GETは他の方法が必要だと思います。
		/// <summary>
		/// GET要請を行います。
		/// </summary>
		/// <typeparam name="T">指定された任意のタイプ</typeparam>
		/// <param name="uri">URI</param>
		/// <param name="param">渡すパラメータ</param>
		/// <returns>通信返事</returns>
		private async Task<T> GetAsync<T>(string uri, object param)
		{
			T result = default;
			// パラメータ
			string jsonParam = JsonConvert.SerializeObject(param);
			string jsonResult;
			HttpClient client = new HttpClient();
			// メソッド、URI、パラメータセット
			HttpRequestMessage request = new HttpRequestMessage
			{
				Method = HttpMethod.Get,
				RequestUri = new Uri(uri),
			};
			HttpResponseMessage response;

			// ヘッダーはJSON
			client.DefaultRequestHeaders
				  .Accept
				  .Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

			// 通信
			response = await client.GetAsync(uri).ConfigureAwait(false);

			// 失敗したらThrowします。
			// TODO try catch作成
			response.EnsureSuccessStatusCode();
			// 結果取得
			jsonResult = await response.Content.ReadAsStringAsync();
			// JSONをオブジェクトに変換
			result = JsonConvert.DeserializeObject<T>(jsonResult);

			return result;
		}

		/// <summary>
		/// POST・PUT・DELETE要請を行います。
		/// </summary>
		/// <typeparam name="T">指定された任意のタイプ</typeparam>
		/// <param name="method">Httpメソッド</param>
		/// <param name="uri">URI</param>
		/// <param name="param">渡すパラメータ</param>
		/// <returns>通信返事</returns>
		private async Task<T> RequestAsync<T>(HttpMethod method, string uri, object param)
		{
			T result = default;
			// パラメータ
			string jsonParam = JsonConvert.SerializeObject(param);
			string jsonResult;
			HttpClient client = new HttpClient();
			// メソッド、URI、パラメータセット
			HttpRequestMessage request = new HttpRequestMessage 
			{
				Method = method,
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
