using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wk2Demo
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username = textUserName.Text;
            String password = txtPassword.Text;

            if(username=="abc" && password == "123")
            {
                MessageBox.Show("Successful Login");
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            textUserName.Text = "";
            txtPassword.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin.ActiveForm.Close();
        }
    }
}
