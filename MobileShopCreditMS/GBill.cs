using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Data;
using System.Data.SqlClient;

namespace MobileShopCreditMS
{
    public partial class GBill : Form
    {
        int totalamt = 0;
        string partialpayment = "Full";
        /*Padma*/
       // SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
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
        private void gpdf(string customerId)
        {
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

                    float[] columnWidths = { 1, 5, 2 };
                    Table table = new Table(columnWidths);
                    table.SetWidth(UnitValue.CreatePercentValue(100));
                    // Initialize total price variable
                    decimal totalPrice = 0;
                    decimal srno = 0;

                    // Add items to the table
                    // Replace this with actual data from your database
                    foreach (DataGridViewRow row in dgcart.Rows)
                    {
                        // Assuming you have four columns: Quantity, Product Name, Price, and Total
                        string quantity = row.Cells["Column2"].Value.ToString(); // Change "QuantityColumn" to the actual name of the column
                        string productName = row.Cells["Column3"].Value.ToString(); // Change "ProductNameColumn" to the actual name of the column
                        string price = row.Cells["Column4"].Value.ToString(); // Change "PriceColumn" to the actual name of the column

                        // Calculate total price
                        decimal itemPrice = decimal.Parse(price);
                        decimal itemQuantity = decimal.Parse(quantity);
                        decimal totalPriceForItem = itemPrice * itemQuantity;
                        totalPrice += totalPriceForItem;

                        // Increment serial number
                        srno += 1;
                        string s = srno.ToString();

                        // Add cells to the table
                        table.AddCell(CreateCell(s, TextAlignment.LEFT));
                        table.AddCell(CreateCell(productName, TextAlignment.LEFT));
                        table.AddCell(CreateCell(price, TextAlignment.RIGHT));
                        table.AddCell(CreateCell(quantity, TextAlignment.CENTER));
                        table.AddCell(CreateCell(totalPriceForItem.ToString(), TextAlignment.RIGHT));
                    }

                    // Add a row for total price
                    table.AddCell(new Cell(1, 4).Add(new Paragraph("Total Price:")).SetTextAlignment(TextAlignment.RIGHT));
                    table.AddCell(new Cell(1, 1));
                    table.AddCell(new Cell(1, 1));
                    table.AddCell(new Cell(1, 1));
                    table.AddCell(CreateCell(totalPrice.ToString(), TextAlignment.RIGHT));

                    // Add the table to the document
                    document.Add(table);


                    // Add closing message
                    Paragraph closing = new Paragraph("THANK YOU FOR PURCHASING.\nDO VISIT AGAIN").SetTextAlignment(TextAlignment.CENTER).SetFontSize(10);
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
              //  int t = q * pp;
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
                MessageBox.Show("bill generated");




                //Product going in MpBills
                string cmd1 = "SELECT MAX(BillId) FROM Bill";
                SqlCommand command = new SqlCommand(cmd1, con);

                int lastId = Convert.ToInt32(command.ExecuteScalar());


                foreach (DataGridViewRow row in dgcart.Rows)
                {
                    int pid = int.Parse(row.Cells[0].Value.ToString());
                    string pname = row.Cells[1].Value.ToString();
                    string quan = row.Cells[2].Value.ToString();
                    string ttamt = row.Cells[3].Value.ToString();

                    string query1 = " insert into MPBills values('" + pid + "','" + lastId + "','" + pname + "','" + ttamt + "')";
                    SqlCommand command1 = new SqlCommand(query1, con);
                    command1.ExecuteNonQuery();

                    //update inventory
                    
                    string updateQuery = "UPDATE Product SET StockQuantity = StockQuantity - @Quantity WHERE ProductID = @ProductID";
                    SqlCommand updateCommand = new SqlCommand(updateQuery, con);
                    updateCommand.Parameters.AddWithValue("@Quantity", quan);
                    updateCommand.Parameters.AddWithValue("@ProductID", pid);
                    updateCommand.ExecuteNonQuery();
                    
                }
                gpdf(lastId.ToString());
                con.Close();
            
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            //
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
            lblRMAmt.Text = "0";
            lblTAmt.Text = "0";
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

            txtpid.Text = "";
            txtPName.Text = "";
           // txtpp.Text = "";
           // txtQnty.Text = "";

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



        

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            var t = new Total();
            t.Show();
        }

        private void txtPAmt_TextChanged_1(object sender, EventArgs e)
        {
            int ttl = int.Parse(lblTAmt.Text);
            int pamt = int.Parse(txtPAmt.Text);
            int r = ttl - pamt;
            lblRMAmt.Text = r.ToString();
        }
    }
}
