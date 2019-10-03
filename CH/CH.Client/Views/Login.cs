using System;
using System.Windows.Forms;

namespace CH.Client.Views
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsError())
                {
                    return;
                }

                
            }
            catch
            {

            }
            finally
            {
                this.Visible = false;
                Main main = new Main();
                main.ShowDialog();
                this.Close();
            }
        }

        private bool IsError()
        {
            if (string.IsNullOrEmpty(txtAccount.Text))
            {
                MessageBox.Show("アカウント名を入力してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("パスワードを入力してください。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            // 正常の場合falseを返します。
            return false;
        }
    }
}
