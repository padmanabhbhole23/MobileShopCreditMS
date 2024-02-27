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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Diagnostics.Eventing.Reader;

namespace MobileShopCreditMS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                // Perform the action associated with your button
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter username");
            }
            else if (textPass.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            else
            {
                try
                {
                    /*Padma*/
                   SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
                    /*AFFAN*/ //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");
                             // chnages the db to MSlocal with dbname=project and table name=usr
                    string query = "select * from usr where name='" + textBox1.Text + "'and pass='" + textPass.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();
                        
                        if (textBox1.Text.Equals("admin"))
                        {
                            var ADash = new ADash();
                            ADash.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Id or Password Incorrect!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            textPass.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
