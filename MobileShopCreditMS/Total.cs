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
        // SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        //affan
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        public Total()
        {
            InitializeComponent();
            populate();

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
            this.Hide();
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
            button4.Visible = false;
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

            //update bill table

            int id = int.Parse(DGTTL.SelectedRows[0].Cells[3].Value.ToString());
            int amt = int.Parse(txtET.Text);
            con.Open();
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
            con.Close();
            MessageBox.Show("amount updated successfully");

            if (par == "Full")
            {
                MessageBox.Show("ALL CREDIT AMOUNT PAID..!");
            }
            label4.Text = c.ToString();
            textBox1.Clear();
            txtET.Clear();
            populate();//parat selection change hotai yash la karun bg

            label6.Visible = false;
            label7.Visible = false;
            textBox2.Visible = false;
            button4.Visible = false;

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
                button4.Visible = true;
                textBox2.Clear();
                label6.Visible = false;
                label7.Visible = false;
                textBox2.Visible = false;
            }
            else
            {
                MessageBox.Show(" Password Incorrect!");
            }
            con.Close();

          

        }
    }
}
/*
 * 
 * con.Open();
            string query = "select * from usr where name='admin' and pass='" + textBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                button4.Visible = true;
            }
            else
            {
                MessageBox.Show(" Password Incorrect!");
            }
            con.Close();

*/