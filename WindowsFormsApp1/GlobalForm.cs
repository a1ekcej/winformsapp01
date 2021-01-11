using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class GlobalForm : Form
    {
        public string LoginTXT
        {
            get { return TXTloginUser.Text; }
            set { TXTloginUser.Text = value; }
        }
        public GlobalForm()
        {
            AutorizationForm autof = new AutorizationForm();
            InitializeComponent();
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
