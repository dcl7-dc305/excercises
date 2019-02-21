using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace wk4Excercise
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        string ConnStr = ConfigurationManager.ConnectionStrings["myRegister"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            Load_GridRegisterDetails();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" || txtFirstName.Text == "" || txtLastName.Text == "" || txtAge.Text =="" )
            {
                MessageBox.Show("Must fill in the blanks");
            }
            else
            {
                conn = new SqlConnection(ConnStr);
                cmd = new SqlCommand("INSERT into register (email, username, password, firstname, lastname, age) VALUES (@email, @username, @password, @firstname, @lastname, @age)", conn);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);

                try
                {
                    conn.Open();
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        // If successful query
                        //lblStatus.ForeColor = System.Drawing.Color.Green;
                        //lblStatus.Text = "Succesfully Added";
                        MessageBox.Show("User Successfully added!");
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

        private void btnView_Click(object sender, EventArgs e)
        {
            Load_GridRegisterDetails();
        }

        public void Load_GridRegisterDetails()
        {
            SqlDataReader reader; // create reader object
            DataTable dt = new DataTable(); // create datatable object
            conn = new SqlConnection(ConnStr); // assign the connection info
            cmd = new SqlCommand("select * from register", conn);
            try
            {
                conn.Open(); // open connection
                reader = cmd.ExecuteReader(); // execute command and assign the result into
                if (reader.HasRows) // check if there is any record in reader
                {
                    dt.Load(reader); // copy the record from reader to datatable
                    dtReg.DataSource = dt; // assign the datasource to gridview
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
