using System;
using Glenshield.Communication;
using Glenshield.Cryptography;
using System.Windows.Forms;

namespace DisclosureController.Forms
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void cmdOK_Click(object sender, EventArgs e)
        {
            clsSharedData.gUser = txtUserID.Text;
            clsSharedData.gPassword = txtPassword.Text;
            this.Dispose();
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            clsSharedData.gUser = "";
            clsSharedData.gPassword = "";
            this.Dispose();
        }
    }
}
