using CH.Client.Utility;
using System.Windows.Forms;

namespace CH.Client.Views.Common
{
	public partial class BaseForm : Form
	{
		HttpCommunicator HttpCommunicator { get; set; }

		public BaseForm()
		{
			InitializeComponent();
			HttpCommunicator = new HttpCommunicator();
		}

		public T Get<T>(string controllerName, string functionName, object param = null)
		{
			return HttpCommunicator.Get<T>(controllerName, functionName, param);
		}
	}
}
