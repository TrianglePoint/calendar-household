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
            if(!checkError()){
                //임시 로그인 아이디 : admin 
                if (txtAccount.Text.Equals("admin") && txtPassword.Text.Equals("pass"))
                {
                    this.Visible = false;
                    Main main = new Main();
                    main.ShowDialog();
                    this.Close();
                }

            }
        }

        private bool checkError()
        {
            if (string.IsNullOrEmpty(txtAccount.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("IDまたはPASSWORDOOを入力してください。", "",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtAccount.Focus();
                return true;
            }
            if (!txtAccount.Text.Equals("admin")|| !txtPassword.Text.Equals("pass"))
            {
                MessageBox.Show("一致する会員情報がありません。", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return true;
            }
            return false;
        }
    }
}
