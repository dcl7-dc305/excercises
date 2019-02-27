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
        SqlCommand checkercmd;
        string ConnStr = ConfigurationManager.ConnectionStrings["myRegister"].ConnectionString;

        public Form1()
        {
            InitializeComponent();
            Load_GridRegisterDetails();
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
                cmd = new SqlCommand("INSERT into register (student_id, email, username, password, firstname, lastname, age) VALUES (@student_id, @email, @username, @password, @firstname, @lastname, @age)", conn);
                cmd.Parameters.AddWithValue("@student_id", txtStudentId.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@firstname", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@lastname", txtLastName.Text);
                cmd.Parameters.AddWithValue("@age", txtAge.Text);

                checkercmd = new SqlCommand("SELECT * from register WHERE student_id=@student_id", conn);
                checkercmd.Parameters.AddWithValue("@student_id", txtStudentId.Text);


                try
                {
                    SqlDataReader reader; // create reader object
                    
                    conn.Open();
                    reader = checkercmd.ExecuteReader();
                    if (reader.HasRows) // Check if there's existing record don't enter data
                    {
                        MessageBox.Show("Error Existing Record: " + txtStudentId.Text);
                        reader.Close();
                    }
                    else
                    {
                        reader.Close();
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            // If successful query
                            //lblStatus.ForeColor = System.Drawing.Color.Green;
                            //lblStatus.Text = "Succesfully Added";
                            MessageBox.Show("User Successfully added!");
                        }
                    }
                    conn.Close();
                    Load_GridRegisterDetails();
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnStr);
            cmd = new SqlCommand("UPDATE register SET email=@email, username=@username, password=@password, firstname=@firstname, lastname=@lastname, age=@age WHERE student_id=@student_id", conn);
            cmd.Parameters.AddWithValue("@student_id", txtStudentId.Text);
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
                    MessageBox.Show("Success");
                    Load_GridRegisterDetails();

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dtReg.Rows[e.RowIndex];

            // Insert to Textboxes from Table
            txtStudentId.Text = row.Cells["student_id"].Value.ToString();
            txtUsername.Text = row.Cells["username"].Value.ToString();
            txtPassword.Text = row.Cells["password"].Value.ToString();
            txtEmail.Text = row.Cells["email"].Value.ToString();
            txtFirstName.Text = row.Cells["firstname"].Value.ToString();
            txtLastName.Text = row.Cells["lastname"].Value.ToString();
            txtAge.Text = row.Cells["age"].Value.ToString();
            txtStudentId.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn = new SqlConnection(ConnStr);
            cmd = new SqlCommand("DELETE FROM register WHERE student_id=@student_id", conn);
            cmd.Parameters.AddWithValue("@student_id", txtStudentId.Text);

            try
            {
                conn.Open();

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Delete Successfully");
                    Load_GridRegisterDetails();
                    txtStudentId.Text = "";
                    txtEmail.Text = "";
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                    txtStudentId.Enabled = true;
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
