using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;




namespace MobileShopCreditMS
{
    public partial class SNotification : Form
    {
        public SNotification()
        {
            InitializeComponent();
        }


        /*Padma*/
        //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        //affan
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                const string accountsid = "AC7de3ff2e20df4f87d508aa6902ec30bb";
                const string authtoken = "fd23d4c87ae6354b0437f9872ae85d24";
                //AC7de3ff2e20df4f87d508aa6902ec30bb

                TwilioClient.Init(accountsid, authtoken);

                MessageResource.Create(
                    to: new PhoneNumber("+91" + textBox2.Text),
                    from: new PhoneNumber("+16505819725"),
                    body: textBox1.Text);

                MessageBox.Show("Message sent successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Message sending failed");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var c = new ADash();
            c.Show();
        }

        private void rbsms_Click(object sender, EventArgs e)
        {
            smspanel.Visible = true;
            whtsppanel.Visible = false;
        }

        private void rbwhatsapp_Click(object sender, EventArgs e)
        {
            smspanel.Visible = false;
            whtsppanel.Visible = true;
        }
        public void sendwhatsapp(string number, string message)
        {
            try
            {
                if (number.Length <= 0 && number.Length > 10)
                {
                    MessageBox.Show("PLEASE ENTER VALID MOBILE NUMBER");
                }
                else
                {
                    number = "+91" + number;

                }
                number = number.Replace(" ", "");
                string url = "http://api.whatsapp.com/send?phone=" + number + "&text=" + message;

                try
                {
                    // Start the process with the URL
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true,
                        WorkingDirectory = @"C:\" // Specify a working directory here, change as needed
                    });
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnwhtssms_Click(object sender, EventArgs e)
        {
            sendwhatsapp(txtcustmob.Text, txtwtxt.Text);
        }
        private void PerformSearch()
        {
            string searchTerm = txtSearch.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                try
                {

                    con.Open();
                    string query = "SELECT CustomerId,FirstName,MidName,LastName,PhoneNo FROM Customer WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm OR CustomerId LIKE @SearchTerm";
                    SqlCommand command = new SqlCommand(query, con);
                    command.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    custgview.DataSource = dataTable;
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
            else
            {
                custgview.DataSource = null; // Clear DataGridView if search term is empty
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            PerformSearch();
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void custgview_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (custgview.SelectedRows.Count > 0)
            {
                // Assuming your DataGridView has a column named "MobileNoColumn"
                string mobileNo = custgview.SelectedRows[0].Cells["PhoneNo"].Value.ToString();
                txtcustmob.Text = mobileNo;
            }
        }

        private void custgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
