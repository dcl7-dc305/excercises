using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Right Click on Solutions then Properties > Settings
// Type: Connection String, Scope = Application, 
// Copy and Paste Value from [Double Click on DB from Server Exploerer CHECK PROPERTIES BOX from BOTTOM RIGHT]

// then Connect db using this module
using System.Data.SqlClient;
using System.Configuration;

namespace wk3Demo
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string ConnStr = ConfigurationManager.ConnectionStrings["MyStudent"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            Load_GridStudentDetails();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtEmail.Text == "") 
            {
                MessageBox.Show("Must fill in the blanks");
            }
            else
            {
                conn = new SqlConnection(ConnStr); // Create connection object
                cmd = new SqlCommand("INSERT INTO login (student_id,username,password,email) VALUES (@student_id, @username, @password, @email)", conn);
                cmd.Parameters.AddWithValue("@student_id", txtStudentID.Text); //Input Component => "txtStudent.Text"
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        // If successful query
                        lblStatus.ForeColor = System.Drawing.Color.Green;
                        lblStatus.Text = "Succesfully Added";
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    //Show Error - Message
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Load_GridStudentDetails()
        {
            SqlDataReader reader; // create reader object
            DataTable dt = new DataTable(); // create datatable object
            conn = new SqlConnection(ConnStr); // assign the connection info
            cmd = new SqlCommand("select * from login", conn);
            try
            {
                conn.Open(); // open connection
                reader = cmd.ExecuteReader(); // execute command and assign the result into
                if (reader.HasRows) // check if there is any record in reader
                {
                    dt.Load(reader); // copy the record from reader to datatable
                    grdStudentDetails.DataSource = dt; // assign the datasource to gridview
                }
                else
                {
                    MessageBox.Show("No data to show");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
