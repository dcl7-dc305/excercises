using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wk3Excercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Double roll = Double.Parse(txtRoll.Text);
            String name = txtName.Text;
            Double physics = Double.Parse(txtPhysics.Text);
            Double chem = Double.Parse(txtChem.Text);
            Double ca = Double.Parse(txtCA.Text);
            Double totalMark;
            Double percentage;
            String division;

            if (txtRoll.Text == "" && txtName.Text == "" && txt.Name == "")
            {
                roll = 0;
                if (roll >= 1001)
                {
                    MessageBox.Show("Roll Number: The Maximum Roll is 1000");
                }

            }
            else
            {

                // Total marks
                totalMark = physics + chem + ca;

                // Percentage
                percentage = totalMark / 3;

                // Division
                if (percentage >= 60)
                {
                    division = "First";
                }
                else if (percentage >= 48 && percentage < 60)
                {
                    division = "Second";
                }
                else if (percentage >= 36 && percentage < 48)
                {
                    division = "Third";
                }
                else
                {
                    division = "No Division";
                }

                String msg = "Roll No. : " + roll.ToString() + "\n" + "Name: " + name.ToString() + "\n" + "Physics " + physics.ToString() + "\n" + "Chemistry: " + chem.ToString() + "\n" + "Computer Application: " + ca.ToString() + "\n" + "Total Marks: " + totalMark.ToString() + "\n" + "Percentage: " + percentage.ToString() + "\n" + "Your Division is: " + division + "\n";
                MessageBox.Show(msg);
            }
            
        }
    }
}
