using CH.Client.Views.Common;
using CH.Model.DTO;
using CH.Model.ViewModel;
using System;

namespace CH.Client.Views
{
	public partial class Test : BaseForm
	{
		/// <summary>
		/// 基本コンストラクタ
		/// </summary>
		public Test()
		{
			InitializeComponent();
		}

        /// <summary>
        /// Httpテスト
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnHttp_Click(object sender, EventArgs e)
        {
            label.Text = Get<TestDTO>("Test", "GetTest", new TestViewModel
            {
                Text = "hi!"
            }).ViewModel.Text;
        }
	}
}
