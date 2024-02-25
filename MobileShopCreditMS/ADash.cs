using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopCreditMS
{
    public partial class ADash : Form
    {
        public ADash()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vc = new VCustomers();
            vc.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var vc = new Inventory();
            vc.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var vc = new VCatalogue();
            vc.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var vc = new VReport();
            vc.Show();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var vc = new Total();
            vc.Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var vc = new CPassword();
            vc.Show();
            this.Close();
        }

        private void btnnotify_Click(object sender, EventArgs e)
        {
            var vc = new SNotification();
            vc.Show();
            this.Close();
        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            var vc = new TExpense();
            vc.Show();
            this.Close();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {

        }

        private void ADash_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            var vc = new GBill();
            vc.Show();
            this.Close();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            var login=new Login();
            this.Close();       
            login.Show();
        }
    }
}

