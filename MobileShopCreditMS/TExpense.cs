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
    public partial class TExpense : Form
    {
        /*Padma*/
        //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        //affan
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        public TExpense()
        {
            InitializeComponent();
            showExp();
        }
        private void showExp()
        {
            con.Open();
            string query = "select * from Expenses";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DGExp.DataSource = ds.Tables[0];
            con.Close();
        }
        private void clr()
        {
            txtET.Text = "";
            txtAmt.Text = "";
            txtDesc.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var v = new ADash();
            v.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = true;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            clr();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string date = monthCalendar1.SelectionRange.Start.ToString();
            //con.Open();
            string query = "insert into Expenses values('" + txtET.Text + "','" + date + "','" + txtAmt.Text + "','" + txtDesc.Text + "') ";
            SqlDataAdapter d = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(d);
            var dast = new DataSet();
            d.Fill(dast);
            clr();
            showExp();
            con.Close();

        }

        private void DGExp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
