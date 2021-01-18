using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GlobalForm : Form
    {
        public void LoginTXT(string log, string role)
        {
            textBoxLogin.Text = log;
            textBoxRole.Text = role;
        }
        public GlobalForm()
        {
            AutorizationForm autof = new AutorizationForm();
            InitializeComponent();
        //    UserControl user = new UserControl();
        //    user

        }

        private void addUnit_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void exitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
