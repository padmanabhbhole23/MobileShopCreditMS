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
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;




namespace MobileShopCreditMS
{
    public partial class SNotification : Form
    {
        public SNotification()
        {
            InitializeComponent();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                const string accountsid = "AC7de3ff2e20df4f87d508aa6902ec30bb";
                const string authtoken = "d2bec883e58eacd0e72d962fbf9a4a72";

                TwilioClient.Init(accountsid, authtoken);

                MessageResource.Create(
                    to: new PhoneNumber("+91" + textBox2.Text),
                    from: new PhoneNumber("+16505819725"),
                    body: textBox1.Text);

                MessageBox.Show("successfull");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("failed");
            }
        }
    }
}
