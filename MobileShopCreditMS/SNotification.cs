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
            populate();
        }


        /*Padma*/
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        //affan
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        private void button2_Click(object sender, EventArgs e)
        {
            //string custid = custgview.SelectedRows[0].Cells["CustomerId"].Value.ToString();
            //con.Open();
            //string cmd1 = "SELECT  FROM Bill WHERE CustomerId="+custid;
            //SqlCommand command = new SqlCommand(cmd1, con);

            //int lastId = Convert.ToInt32(command.ExecuteScalar());
            try
            {
                const string accountsid = "AC7de3ff2e20df4f87d508aa6902ec30bb";
                const string authtoken = "941cde263134a09f5717c14a22a033d1";

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
        private void populate()
        {
            con.Open();
            string query = "select c.FirstName,c.MidName,c.LastName,c.PhoneNo ,b.*  FROM Customer c JOIN bill b ON c.customerId=b.customerId where PaymentStatus='Half'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            custgview.DataSource = ds.Tables[0];
            con.Close();
        }/*
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
        }*/


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
                textBox2.Text = mobileNo;
            }
        }

        private void custgview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string mobileNo = custgview.SelectedRows[0].Cells["PhoneNo"].Value.ToString();
            txtcustmob.Text = mobileNo;
            textBox2.Text = mobileNo;
            int t = int.Parse(custgview.SelectedRows[0].Cells[7].Value.ToString());
            int p = int.Parse(custgview.SelectedRows[0].Cells[9].Value.ToString());
            int c = t - p;
            textBox1.Text = "This message is sent from *PHONELINK SHOPIEE* \nRemaining Credit:" + c.ToString() + "Pay your credits asap...";
            txtwtxt.Text = "This message is sent from *PHONELINK SHOPIEE* \nRemaining Credit:" + c.ToString() + "Pay your credits asap...";


        }

        private void rbsms_CheckedChanged(object sender, EventArgs e)
        {
           

        }
    }
}
