using DisclosureController.Forms;
using System;
using System.Windows.Forms;

namespace DisclosureController
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Form loginForm = new frmLogin();
            loginForm.ShowDialog(this);

            if (LoginAttemptMade())
            {

            }
        }

        private bool LoginAttemptMade()
        {
            if (clsSharedData.gUser != "" && clsSharedData.gPassword != "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            

        }
    }
}
