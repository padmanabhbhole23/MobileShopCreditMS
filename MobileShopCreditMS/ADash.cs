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
    }
}

