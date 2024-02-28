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
            int c = t - p;
            label4.Text = c.ToString();

        }

        private void txtET_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //update bill table
            int id=int.Parse( DGTTL.SelectedRows[0].Cells[3].Value.ToString());
            int amt =int.Parse( txtET.Text);
            con.Open();
            

            string updateQuery = "UPDATE bill SET PaidAmount=PaidAmount + @paid,Paymentstatus='Full' WHERE BillId=@bill ";
            SqlCommand updateCommand = new SqlCommand(updateQuery, con);
            updateCommand.Parameters.AddWithValue("@paid", amt);
            updateCommand.Parameters.AddWithValue("@bill", id);
            updateCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("amount updated successfully");
            populate();


        }
    }
}
