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
    public partial class VCustomers : Form
    {
        public VCustomers()
        {
            InitializeComponent();
        }
        /*Padma*/ //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
       //affan
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dash = new ADash();
            dash.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dash = new ADDCus();
            dash.Show();
        }

        private void customer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void populate()
        {
            con.Open();
            string query = "select * from Customer";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            customer.DataSource = ds.Tables[0];
            con.Close();
        }

        

        

        

       
        private void button5_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
