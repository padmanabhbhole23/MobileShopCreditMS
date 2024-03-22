using DocumentFormat.OpenXml.Vml;
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

namespace MobileShopCreditMS
{
    public partial class Total : Form
    {
        int c = 0;
        /*Padma*/
         SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        //affan
      //  SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        public Total()
        {
            InitializeComponent();
            populate();
            string q2 = "select SUM((TotalAmount-PaidAmount)) from bill where PaymentStatus='Half'";
            con.Open();
            SqlCommand command = new SqlCommand(q2, con);
            int tc = Convert.ToInt32(command.ExecuteScalar());
            lblTC.Text = tc.ToString();
            con.Close();
        }
        private void populate()
        {
            con.Open();
            string query = "select c.FirstName,c.MidName,c.LastName,b.*  FROM Customer c JOIN bill b ON c.customerId=b.customerId where PaymentStatus='Half'";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGTTL.DataSource = ds.Tables[0];
            con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var a = new ADash();
            a.Show();
        }

        private void DGTTL_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = DGTTL.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label6.Visible = false;
            textBox2.Visible = false;
            EDITPANEL.Visible = true;
        }

        private void lblAmt_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int t = int.Parse(DGTTL.SelectedRows[0].Cells[6].Value.ToString());
            int p = int.Parse(DGTTL.SelectedRows[0].Cells[8].Value.ToString());
            c = t - p;
            label4.Text = c.ToString();

        }

        private void txtET_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox2.Visible = true;
            label6.Visible = true;
            label7.Visible = true;


        }

        private void label7_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from usr where name='admin' and pass='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            

            if (dt.Rows.Count > 0)
            {
                

                int id = int.Parse(DGTTL.SelectedRows[0].Cells[3].Value.ToString());
                int amt = int.Parse(txtET.Text);
               
                string par = "Half";
                if (label4.Text == txtET.Text)
                {
                    par = "Full";
                }
                
                string updateQuery = "UPDATE bill SET PaidAmount=PaidAmount + @paid,Paymentstatus='" + par + "' WHERE BillId=@bill ";
                SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                updateCommand.Parameters.AddWithValue("@paid", amt);
                updateCommand.Parameters.AddWithValue("@bill", id);
                updateCommand.ExecuteNonQuery();

                string upCredit = "update Credits SET PayAmount='"+ label4.Text+ "' WHERE BillId=@bid";
                SqlCommand sqlCommand = new SqlCommand(upCredit, con);
                updateCommand.Parameters.AddWithValue("@bid", id);
                updateCommand.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("amount updated successfully");

                if (par == "Full")
                {
                    MessageBox.Show("ALL CREDIT AMOUNT PAID OF THIS BILL..!");
                }
                label4.Text = c.ToString();
                //textBox1.Clear();
                txtET.Clear();
                populate();

                label6.Visible = false;
                label7.Visible = false;
                textBox2.Visible = false;
               
                textBox2.Clear();
                label4.Text = "0";


            }
            else
            {
                MessageBox.Show(" Password Incorrect!");
                con.Close();
            }

            


        }
    }
}
