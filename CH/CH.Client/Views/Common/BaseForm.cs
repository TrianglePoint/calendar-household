using Newtonsoft.Json;
using System.IO;
using System.Net;
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
        private string apiURI = string.Format("https://{0}:{1}/api", HOST, PORT);

        public T Get<T>(string controllerName, string functionName, object param)
        {
            string uri = string.Format("{0}/{1}/{2}", apiURI, controllerName, functionName);

            return Get<T>(uri, param);
        }

        /// <summary>
        /// 
        /// </summary>
        private T Get<T>(string uri, object param)
        {
            T result = default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response;

            request.ContentType = "application/json";
            request.Method = "GET";

            response = (HttpWebResponse)request.GetResponse();
            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream()))
                {
                    result = JsonConvert.DeserializeObject<T>(reader.ReadToEnd());
                }
            }

            return result;
        }
    }
}
