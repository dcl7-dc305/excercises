using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk4Excercise
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool IsOpen = false;
            foreach (Form f in Application.OpenForms)
            {
                if(f.Text == "Login")
                {
                    IsOpen = true;
                    f.Focus();
                    break;
                }
            }
            if(IsOpen == false)
            {
                Login frmLogin = new Login();
                frmLogin.MdiParent = this;
                frmLogin.Show();
            }
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.MdiParent = this;
            frm1.Show();
        }
    }
}
