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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClickMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello" + frmName.Text);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            frmName.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmWelcome.ActiveForm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new frmLogin().Show();
        }
    }
}
