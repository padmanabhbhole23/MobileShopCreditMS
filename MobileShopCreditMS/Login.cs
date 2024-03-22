using System.Data;
using System.Data.SqlClient;

namespace MobileShopCreditMS
{

    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter username");
            }
            else if (textPass.Text == "")
            {
                MessageBox.Show("Enter password");
            }
            else
            {

                try
                {
                    /*Padma*/
                    SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;");
                    /*AFFAN*/
                    //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

                    string query = "select * from usr where name='" + textBox1.Text + "'and pass='" + textPass.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dataAdapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful");
                        this.Hide();

                        if (textBox1.Text.Equals("admin"))
                        {
                            var ADash = new ADash();
                            ADash.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Login Id or Password Incorrect!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }
            }
        }

 
        private void label1_Click(object sender, EventArgs e)
        {
            textPass.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
