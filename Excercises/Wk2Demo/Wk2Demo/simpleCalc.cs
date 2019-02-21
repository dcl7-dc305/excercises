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
    public partial class simpleCalc : Form
    {
        public simpleCalc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            Double num1 = double.Parse(txtNum1.Text);
            Double num2 = double.Parse(txtNum2.Text);
            String ope = cboOperation.SelectedItem.ToString();
            Double result = 0;

            switch (ope)
            {
                case ("+"):
                    result = num1 + num2;
                    break;
                case ("-"):
                    result = num1 - num2;
                    break;
                case ("*"):
                    result = num1 * num2;
                    break;
                case ("/"):
                    result = num1 / num2;
                    break;
            }

            txtResult.Text = result.ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
            txtNum1.Text = "";
            txtNum2.Text = "";
        }

        private void cboOperation_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void simpleCalc_Load(object sender, EventArgs e)
        {
            cboOperation.SelectedIndex = 0; // Selected combo onload  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            simpleCalc.ActiveForm.Close();
        }
    }
}
