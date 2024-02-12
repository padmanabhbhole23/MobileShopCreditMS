using System.Data.SqlClient;
using System.Data;
namespace MobileShopCreditMS
{
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
              
        }

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
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
                SqlCommand cmd = new SqlCommand("insert into Customer values('"+txt);
            }
            catch(Exception ex)
            {
                MessageBox.Show("" + ex);
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
