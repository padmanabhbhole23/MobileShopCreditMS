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
            /*if()
            {

            }
            else
            {

            }*/
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtMName.Text = "";
            txtLName.Text = "";
            txtCAdd.Text = "";
            txtCont..Text = "";
            txtEmail.Text = "";
            txt

        }
    }
}
