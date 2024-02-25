using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Twilio;
using Twilio.Rest.Api.V2010.Account;


namespace MobileShopCreditMS
{
    public partial class SNotification : Form
    {
        const string accountSid = "AC8100de74a643fe0f214d667c02d2a3bb";
        const string authToken = "76309b5e1c222cf9879844a42b7ddd2a";

        public SNotification()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                TwilioClient.Init(accountSid, authToken);

                var message = MessageResource.Create(
                    body: textBox1.Text,
                    from: new Twilio.Types.PhoneNumber("+919860017436"),
                    to: new Twilio.Types.PhoneNumber("+918669017436")
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
