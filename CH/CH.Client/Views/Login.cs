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
            this.Visible = false;
            Main main = new Main();
            main.ShowDialog();
            this.Close();
        }
    }
}
