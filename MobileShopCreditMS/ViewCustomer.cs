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
    }
}
