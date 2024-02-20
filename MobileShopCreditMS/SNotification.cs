using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobileShopCreditMS
{
    public partial class SNotification : Form
    {
        public SNotification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                WebClient cl = new WebClient();
                Stream s = cl.OpenRead(string.Format("http://api.clickatell.com/http/sendmsg?user=unclepaani1708363628&password=uncleJIpaani2&api_id=[d6f4978ee1c7430cb3d0bea54906c651]&to=(0)&text=(1)",9860017436,textBox1.Text));
                StreamReader reader = new StreamReader(s);  
                string result= reader.ReadToEnd();
                MessageBox.Show(result,"Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
