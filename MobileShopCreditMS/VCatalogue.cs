using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class VCatalogue : Form
    {
       
        /*Padma*/
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        //affan
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");
        public VCatalogue()
        {
            InitializeComponent();
            con.Open();
            string query = "select * from Product where StockQuantity>=1";
            string q2 = "select SUM(StockQuantity) from Product";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommand showc = new SqlCommand(q2, con);
            string c=showc.ExecuteScalar().ToString();
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgv1.DataSource = ds.Tables[0];
            con.Close();
            lblTSQ.Text = c;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var vr = new ADash();
            this.Close();
            vr.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
