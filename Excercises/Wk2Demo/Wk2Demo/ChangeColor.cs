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
    public partial class ChangeColor : Form
    {
        public ChangeColor()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rdoRed_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void rdoBlue_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void rdoYellow_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void rdoGreen_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You are from " + lstCountry.SelectedItem.ToString());
        }
    }
}
