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
using DocumentFormat.OpenXml.VariantTypes;
using iText.Bouncycastlefips.Math;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using Org.BouncyCastle.Crypto.General;
using System.Drawing;

namespace MobileShopCreditMS
{
    public partial class GBill : Form
    {
        int totalamt = 0;
        string partialpayment = "Full";
        /*Padma*/
        //SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        //affan
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        public GBill()
        {
            InitializeComponent();
            populateproduct();
            populatecust();
        }
        private void populateproduct()
        {
            con.Open();
            string query = "select ProductId,ProductName,ProductPrice,Category, Brand,StockQuantity from Product";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgproduct.DataSource = ds.Tables[0];
            con.Close();
        }
        private void populatecust()
        {
            con.Open();
            string query = "select CustomerId,FirstName,MidName,LastName,PhoneNo from Customer";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgcust.DataSource = ds.Tables[0];
            con.Close();
        }
        private void gpdf()
        {
            /*
            string path = @"E:\Padmanabh\PROJECT\invoice.pdf";
            PdfWriter writer = new PdfWriter(path);
            PdfDocument pdf = new PdfDocument(writer);
            Document document = new Document(pdf);

            //document.Close();
            */
            //string customerId = txtCustID.Text.Trim();
            string customerId = 101.ToString();
            /*
            if (string.IsNullOrEmpty(customerId))
            {
                MessageBox.Show("Please enter a customer ID.");
                return;
            }*/


            string fileName = $"Invoice_{customerId}.pdf";
            //string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "PDF Files|*.pdf";
            saveFileDialog1.Title = "Save PDF Bill";
            saveFileDialog1.FileName = fileName; // Default file name
            DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string filePath = saveFileDialog1.FileName;

                // Create a new PDF document
                using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    PdfWriter writer = new PdfWriter(fs);
                    PdfDocument pdf = new PdfDocument(writer);
                    Document document = new Document(pdf);

                    // Title
                    Paragraph title = new Paragraph("Invoice").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20);
                    Paragraph shopInfo = new Paragraph("PHONELINK\nAddress\nContact No\nGST No\nEmail")
                        .SetTextAlignment(TextAlignment.CENTER).SetFontSize(10);
                    document.Add(title);
                    document.Add(shopInfo);

                    // Add table for items
                    float[] columnWidths = { 1, 5, 2 };
                    Table table = new Table(columnWidths);
                    table.SetWidth(UnitValue.CreatePercentValue(100));
                    table.AddCell(CreateHeaderCell("Sr No."));
                    table.AddCell(CreateHeaderCell("Item Name"));
                    table.AddCell(CreateHeaderCell("Item Price"));

                    // Add items to the table
                    // Replace this with actual data from your database
                    table.AddCell(CreateCell("1", TextAlignment.CENTER));
                    table.AddCell(CreateCell("Product A", TextAlignment.LEFT));
                    table.AddCell(CreateCell("$10", TextAlignment.RIGHT));

                    table.AddCell(CreateCell("2", TextAlignment.CENTER));
                    table.AddCell(CreateCell("Product B", TextAlignment.LEFT));
                    table.AddCell(CreateCell("$20", TextAlignment.RIGHT));

                    document.Add(table);

                    // Add total amount
                    double totalAmount = 30; // Replace with actual total amount
                    Paragraph total = new Paragraph($"Total: ${totalAmount}").SetTextAlignment(TextAlignment.RIGHT);
                    document.Add(total);

                    // Add GST
                    double gstPercentage = 12;
                    double gstAmount = (totalAmount * gstPercentage) / 100;
                    Paragraph gst = new Paragraph($"GST ({gstPercentage}%): ${gstAmount}").SetTextAlignment(TextAlignment.RIGHT);
                    document.Add(gst);

                    // Add total including GST
                    double totalIncludingGst = totalAmount + gstAmount;
                    Paragraph totalWithGst = new Paragraph($"Total (Including GST): ${totalIncludingGst}").SetTextAlignment(TextAlignment.RIGHT);
                    document.Add(totalWithGst);

                    // Add remaining amount and cash paid
                    double remainingAmount = 0; // Calculate remaining amount
                    double cashPaid = totalIncludingGst; // Assuming cash paid is the total amount
                    Paragraph remainingAndPaid = new Paragraph($"Remaining Amount: ${remainingAmount}\nCash Paid: ${cashPaid}")
                        .SetTextAlignment(TextAlignment.RIGHT);
                    document.Add(remainingAndPaid);

                    // Add closing message
                    Paragraph closing = new Paragraph("THANK YOU FOR PURCHASING.\nDO VISIT AGAIN")
                        .SetTextAlignment(TextAlignment.CENTER).SetFontSize(10);
                    document.Add(closing);

                    // Close the document
                    document.Close();
                }

                MessageBox.Show($"PDF bill generated successfully!\nFile saved to: {filePath}");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            var a = new ADash();
            a.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private Cell CreateHeaderCell(string content)
        {
            return new Cell().Add(new Paragraph(content).SetBold().SetTextAlignment(TextAlignment.CENTER));
        }

        private Cell CreateCell(string content, TextAlignment alignment)
        {
            return new Cell().Add(new Paragraph(content).SetTextAlignment(alignment));
        }
        private void btnGBill_Click(object sender, EventArgs e)
        {
            con.Open();

            DateTime currentDate = DateTime.Now;
            string dateString = currentDate.ToString("yyyy-MM-dd");
            int q = int.Parse(txtQnty.Text);
            int pp = int.Parse(txtpp.Text);
            int t = q * pp;
            string partialpayment;
            if (lblRMAmt.Text == "0")
            {
                partialpayment = "Full";
            }
            else
            {
                partialpayment = "Half";
            }

            string query = " insert into Bill values('" + txtCID.Text + "', '" + dateString + "', '" + totalamt + "', '" + partialpayment + "', '" + txtPAmt.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            con.Close();



            //Product going in MpBills
            string cmd1 = "SELECT MAX(BillId) FROM Bill";
            SqlCommand command = new SqlCommand(cmd1, con);
            con.Open();
            int lastId = Convert.ToInt32(command.ExecuteScalar());
            

            foreach(DataGridViewRow row in dgcart.Rows)
            {
                int pid = int.Parse(row.Cells[0].Value.ToString());
                string pname = row.Cells[1].Value.ToString();
                string quan = row.Cells[2].Value.ToString();
                string ttamt = row.Cells[3].Value.ToString();
                
                string query1 = " insert into MPBills values('"+pid+"','"+lastId+"','"+pname+"','"+ttamt+"')";
                SqlCommand command1 = new SqlCommand(query1, con);
                command1.ExecuteNonQuery();
                

            }
            con.Close();
            //gpdf();
        }





        private void btnView_Click(object sender, EventArgs e)
        {
            this.Close();
            var c = new VCustomers();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            var c = new VCatalogue();
            c.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtCID.Text = "";
            txtQnty.Text = "";
            txtCName.Text = "";
            txtPAmt.Text = "";
            txtPName.Text = "";
            lblRMAmt.Text = "0.0/-";
            lblTAmt.Text = "0.0/-";
            txtpp.Text = "";


        }

        private void combPTYPE_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtCID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdCrt_Click(object sender, EventArgs e)
        {

            DateTime currentDate = DateTime.Now;
            string dateString = currentDate.ToString("yyyy-MM-dd");
            string pid = txtpid.Text;
            string pn = txtPName.Text;
            int q = int.Parse(txtQnty.Text);
            int pp = int.Parse(txtpp.Text);
            string cid = txtCID.Text;
            string cn = txtCName.Text;
            int t = q * pp;
            string[] row = new string[] { pid, pn, q.ToString(), t.ToString() };
            dgcart.Rows.Add(row);
            totalamt += t;

            lblTAmt.Text = totalamt.ToString();
            //txtpp.Text = dgproduct.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void dgproduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtpid.Text = dgproduct.SelectedRows[0].Cells[0].Value.ToString();
            txtPName.Text = dgproduct.SelectedRows[0].Cells[1].Value.ToString();
            txtpp.Text = dgproduct.SelectedRows[0].Cells[2].Value.ToString();

        }

        private void dgcust_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCID.Text = dgcust.SelectedRows[0].Cells[0].Value.ToString();
            txtCName.Text = dgcust.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void dgcart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPAmt_TextChanged(object sender, EventArgs e)
        {
            int ttl = int.Parse(lblTAmt.Text);
            int pamt = int.Parse(txtPAmt.Text);
            int r = ttl-pamt;
            lblRMAmt.Text=r.ToString();
        }
    }
}
