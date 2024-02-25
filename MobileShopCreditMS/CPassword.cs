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
    public partial class CPassword : Form
    {
        public CPassword()
        {
            InitializeComponent();
        }

        private void CPassword_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var v = new ADash();
            this.Close();
            v.Show();
        }
    }
}
