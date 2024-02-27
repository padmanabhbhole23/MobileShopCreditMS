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
    public partial class CPassword : Form
    {
        public CPassword()
        {
            InitializeComponent();
        }
        /*Padma*/
        // SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        /*AFFAN*/
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        private void CPassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var v = new ADash();
            this.Close();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox3.Text==textBox4.Text) 
            {
                try
                {
                    
                    con.Open();
                    
                    string sql = "update usr set pass='"+textBox4.Text+" ' where name='" +textBox1.Text+"';";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Password changed SUCCESSFULLY");
                    con.Close();
                    var login = new Login();
                    this.Close();
                    login.Show();

                }
                catch(Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("password did not match");
            }
        }
    }
}
