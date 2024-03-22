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
    public partial class ADDCus : Form
    {
        public ADDCus()
        {
            InitializeComponent();
            populateCust();
            updateDGV.Visible = false;
            button6.Visible = false;
        }

        /*Affan*/
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");
        /*Padma*/
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void button1_Click1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var dash = new ADash();
            dash.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }


        private void btnView_Click(object sender, EventArgs e)
        {
            var v = new VCustomers();
            this.Close();
            v.Show();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtMName.Text == "" || txtLName.Text == "" || txtCont.Text == "" || txtEmail.Text=="" || txtCAdd.Text=="")
            {
                MessageBox.Show("MISSING INFORMATION");
            }
            else
            {
                try
                {
                    
                    con.Open();
                    String sql = "insert into Customer values('" + txtFName.Text + "','" + txtMName.Text + "','" + txtLName.Text + "','" + txtEmail.Text + "','" + txtCont.Text + "','" + txtCAdd.Text + "','" + txtNomN.Text + "','" + txtNomR.Text + "','" + txtNomC.Text + "','" + txtNomA.Text + "') ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("CUSTOMER ADDED SUCCESSFULLY");
                    con.Close();
                    txtFName.Text = "";
                    txtMName.Text = "";
                    txtLName.Text = "";
                    txtCAdd.Text = "";
                    txtCont.Text = "";
                    txtEmail.Text = "";
                    txtNomA.Text = "";
                    txtNomN.Text = "";
                    txtNomC.Text = "";
                    txtNomR.Text = "";
                    populateCust();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

        private void button6_Click_2(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtMName.Text = "";
            txtLName.Text = "";
            txtCAdd.Text = "";
            txtCont.Text = "";
            txtEmail.Text = "";
            txtNomA.Text = "";
            txtNomN.Text = "";
            txtNomC.Text = "";
            txtNomR.Text = "";
        }

        private void btnView_Click_1(object sender, EventArgs e)
        {
            var v = new VCustomers();
            this.Close();
            v.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            var v = new ADash();
            this.Close();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var v = new VCatalogue();
            this.Close();
            v.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var v = new Inventory();
            this.Close();
            v.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateDGV.Visible = true;
        }

        private void populateCust()
        {
            con.Open();
            string query = "select * from Customer where NomineeName='' ";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            updateDGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void updateDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Visible = false;
            button6.Visible = true;
            txtFName.Text = updateDGV.SelectedRows[0].Cells[1].Value.ToString();
            txtMName.Text = updateDGV.SelectedRows[0].Cells[2].Value.ToString();
            txtLName.Text = updateDGV.SelectedRows[0].Cells[3].Value.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
               
                
                string sql = "UPDATE Customer SET NomineeName='"+ txtNomN.Text + "',NomineeRelationship='"+txtNomR.Text +"',NomineePhone='"+ txtNomC.Text+"',NomineeAddress='"+ txtNomA.Text+"' where FirstName ='"+ txtFName.Text +"';";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer UPDATED SUCCESSFULLY");
                con.Close();
                populateCust();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            con.Close();
        }
    }
}
