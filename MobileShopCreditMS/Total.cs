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
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        //affan
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        public Total()
        {
            InitializeComponent();
            con.Open();
            string query = "SELECT c.FirstName, c.MidName, c.LastName, ct.TransactionDate, ct.CreditAmount, ct.PaymentStatus FROM CreditTransasction ct JOIN Customer c ON ct.CustomerId = c.CustomerId WHERE ct.PaymentStatus = 'Half';";
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
    }
}
