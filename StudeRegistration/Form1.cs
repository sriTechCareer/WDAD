using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudeRegistration
{

    public partial class Form1 : Form
    {
        string connectionString = @"Data Source=DESKTOP-L8IRFRJ\SQLEXPRESS;Initial Catalog=student;Integrated Security=True;Encrypt=False";
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Students (FullName, Email, Age, Address, PhoneNumber) VALUES (@FullName, @Email, @Age, @Address, @PhoneNumber)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Email", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(textBox3.Text));
                    cmd.Parameters.AddWithValue("@Address", textBox4.Text);
                    cmd.Parameters.AddWithValue("@PhoneNumber", textBox5.Text);

                    try
                    {
                        con.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show(rowsAffected > 0 ? "Registration Successful!" : "Registration Failed.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
    }
}
