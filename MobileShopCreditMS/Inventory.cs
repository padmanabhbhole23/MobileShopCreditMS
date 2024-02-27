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
using static System.Runtime.InteropServices.JavaScript.JSType;
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
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        /*AFFAN*/
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

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
        private void ClearT()
        {
            PName.Text = "";
            PDesc.Text = "";
            PPrice.Text = "";
            PCat.Text = "";
            PBrand.Text = "";
            PImage.Text = "";
            PQty.Text = "";
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PName.Text == "" || PPrice.Text == "")
            {
                MessageBox.Show("missing information");
            }
            else
            {
                try
                {
                    con.Open();
                    string sql = "insert into Product values('" + PName.Text + "','" + PDesc.Text + "','" + PPrice.Text + "','" + PCat.SelectedItem.ToString() + "','" + PBrand.Text + "','" + PImage.Text + "','" + PQty.Text + "') ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PRODUCT ADDED SUCCESSFULLY");
                    con.Close();
                    populate();

                    con.Open();
                    DateTime date = DateTime.Now;
                    string query = "insert into Expenses values('" + PName.Text + "','" + date + "','" + PPrice.Text + "','" + PDesc.Text + "')";
                    SqlDataAdapter d = new SqlDataAdapter(query, con);
                    SqlCommandBuilder builder = new SqlCommandBuilder(d);
                    con.Close();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


                ClearT();
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var v = new ADash();
            v.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void products_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            PID.Text = products.SelectedRows[0].Cells[0].Value.ToString();
            PName.Text = products.SelectedRows[0].Cells[1].Value.ToString();
            PDesc.Text = products.SelectedRows[0].Cells[2].Value.ToString();
            PPrice.Text = products.SelectedRows[0].Cells[3].Value.ToString();
            PCat.SelectedItem = products.SelectedRows[0].Cells[4].Value.ToString();
            PBrand.Text = products.SelectedRows[0].Cells[5].Value.ToString();
            PImage.Text = products.SelectedRows[0].Cells[6].Value.ToString();
            PQty.Text = products.SelectedRows[0].Cells[7].Value.ToString();
            

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PID.Text=="")
            {
                MessageBox.Show("missing information");
            }

            else
            {
                try
                {
                    con.Open();
                    //String sql = "update products set pStock='" + pStock.Text + "' where pId='" + pId.Text + "';";
                    string sql = "UPDATE Product SET StockQuantity = '" + PQty.Text + "', ProductPrice = '" + PPrice.Text + "'WHERE ProductID = '" + PID.Text + "'; ";

                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("PRODUCT UPDATED SUCCESSFULLY");
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
    }
}
