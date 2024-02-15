using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace MobileShopCreditMS
{
    public partial class Inventory : Form
    {
        public Inventory()
        {
            InitializeComponent();
        }
        /*Padma*/
        // SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        /*AFFAN*/
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void populate()
        {
            con.Open();
            string query = "select * from Product";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            products.DataSource = ds.Tables[0];
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (PName.Text == ""  || PPrice.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    String sql = "insert into Product values('" + PName.Text + "','" + PDesc.Text + "','" + PPrice.Text + "','" + PCat.SelectedItem.ToString() + "','" + PBrand.Text + "','" + PImage.Text + "','" + PQty.Text + "','" + PDp.Text + "') ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PRODUCT ADDED SUCCESSFULLY");
                    con.Close();
                    populate();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();

            }

        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
