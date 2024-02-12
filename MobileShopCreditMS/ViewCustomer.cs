using System.Data.SqlClient;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Drawing;
using System.Security.Cryptography;
namespace MobileShopCreditMS
{
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
              
        }
        //FOR AFFAN
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        //FOR PADMANABH
        // SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");

        private void button1_Click1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var dash = new ADash();
            dash.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLName.Text == "" || txtMName.Text == "")
            {
                MessageBox.Show("missing information");
            }

            else
            {
                try
                {
                    con.Open();
                    String sql = "insert into Customer values('" + txtFName.Text + "','" + txtLName.Text + "','" + txtEmail.Text + "','" + txtCont.Text + "','" + txtCAdd.Text + "','" + txtNomN.Text + "','" + txtNomR.Text + "','" + txtNomC.Text + "','" + txtNomA.Text + "') ";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("customer ADDED SUCCESSFULLY");
                    con.Close();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                con.Close();

            }

        }

        private void button6_Click_1(object sender, EventArgs e)
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
    }
}
