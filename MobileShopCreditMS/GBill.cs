﻿using ClosedXML.Report.Utils;
using DocumentFormat.OpenXml.Bibliography;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Borders;
using iText.Layout.Element;
using iText.Layout.Properties;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Asn1.Mozilla;
using System.Data;
using System.Data.SqlClient;

namespace MobileShopCreditMS
{
    public partial class GBill : Form
    {
        int totalamt = 0;
        string partialpayment = "Full";
        /*Padma*/
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        //affan
        //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

        public GBill()
        {
            InitializeComponent();
            populateproduct();
            populatecust();
        }
        private void populateproduct()
        {
            con.Open();
            string query = "select ProductId,ProductName,ProductPrice,Category,StockQuantity from Product where StockQuantity>=1";
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
        private void clrall()
        {
            txtCID.Clear();
            txtCName.Clear();
            txtPAmt.Clear();
            txtpid.Clear();
            txtpp.Clear();
            txtQnty.Clear();
            txtPName.Clear();
            dgcart.Rows.Clear();
            lblTAmt.Text = "0";
            lblRMAmt.Text = "0";
            lblTC.Text = "0";
            totalamt = 0;
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
                    Paragraph title = new Paragraph("PHONE LINK").SetTextAlignment(TextAlignment.CENTER).SetFontSize(20).SetBold();
                    Paragraph shopInfo = new Paragraph("Invoice\nPHONE LINK\nShop No 1, Jetty, Bhagvati Bandar Rd, Mirkarwada, Ratnagiri, Maharashtra 415612\nContact No: 7745035535\nphonelink@gmail.com")
                        .SetTextAlignment(TextAlignment.CENTER).SetFontSize(12);
                    document.Add(title);
                    document.Add(shopInfo);

                    float[] columnWidths = { 1, 5, 2 ,1,2};
                    Table table = new Table(columnWidths);
                    table.SetWidth(UnitValue.CreatePercentValue(100));
                    // Initialize total price variable
                    decimal totalPrice = 0;
                    decimal srno = 0;

                    Paragraph separationLine = new Paragraph("-----------------------------------------------------------------------------------------------------------------")
    .SetTextAlignment(TextAlignment.CENTER);
                    document.Add(separationLine);

                    Paragraph header = new Paragraph("ITEM DETAILS");
                    header.SetTextAlignment(TextAlignment.CENTER);
                    document.Add(header);
                    // Add items to the table
                    // Replace this with actual data from your database
                    table.AddHeaderCell("Sr. No");
                    table.AddHeaderCell("Item ");
                    table.AddHeaderCell("Price ");
                    table.AddHeaderCell("Quantity ");
                    table.AddHeaderCell("Total ");
                    foreach (DataGridViewRow row in dgcart.Rows)
                    {
                        
                        string quantity = row.Cells["Column3"].Value.ToString(); 
                        string productName = row.Cells["Column2"].Value.ToString(); 
                        string price = row.Cells["Column4"].Value.ToString();

                        decimal unitprice = decimal.Parse(price) / decimal.Parse(quantity);
                        // Calculate total price
                        decimal itemPrice = decimal.Parse(price);
                        decimal itemQuantity = decimal.Parse(quantity);
                        decimal totalPriceForItem = itemPrice;
                        totalPrice += totalPriceForItem;

                        // Increment serial number
                        srno += 1;
                        string s = srno.ToString();

                        // Add cells to the table
                        table.AddCell(CreateCell(s, TextAlignment.CENTER));
                        table.AddCell(CreateCell(productName, TextAlignment.LEFT));
                        table.AddCell(CreateCell(unitprice.ToString(), TextAlignment.CENTER));
                        table.AddCell(CreateCell(quantity, TextAlignment.CENTER));
                        table.AddCell(CreateCell(totalPriceForItem.ToString(), TextAlignment.RIGHT));
                    }

                    // Add a row for total price
                    // Add a row for total price
                    Cell totalPriceLabelCell = new Cell().Add(new Paragraph("Total Price:")).SetTextAlignment(TextAlignment.RIGHT);
                    Cell totalPriceValueCell = CreateCell(totalPrice.ToString(), TextAlignment.RIGHT);
                    Cell emptyCell = new Cell().SetBorder(Border.NO_BORDER); // Creating an empty cell without borders

                    table.AddCell(emptyCell);
                    table.AddCell(emptyCell);
                    table.AddCell(emptyCell);
                    table.AddCell(totalPriceLabelCell);
                    table.AddCell(totalPriceValueCell);
                    string sts = "";
                    // Add the table to the document
                    document.Add(table);
                    //int d = ((int)totalPrice- int.Parse(lblRMAmt.Text));
                    if (int.Parse(lblRMAmt.Text)==0)
                    {
                        sts = "Full Paid";
                    }
                    else
                    {
                        sts = "Half Paid";
                    }
                    


                    Paragraph status = new Paragraph("\t\tStatus:" + sts+"\n REMAINING AMOUNT:"+ lblRMAmt.Text);
                    document.Add(status).SetTextAlignment(TextAlignment.RIGHT);
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

        private void fillExp(int l)
        {
            con.Open();
            DateTime currentDate = DateTime.Now;
            string dateString = currentDate.ToString("yyyy-MM-dd");
            //update credit
            string updateexp = "insert into Credits values('" + l + "','" + dateString + "','" + lblRMAmt.Text + "')";
            SqlCommand cm1 = new SqlCommand(updateexp, con);
            cm1.ExecuteNonQuery();
            con.Close();
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
            string q2 = "select NomineeName from Customer where CustomerId='" + txtCID.Text + "'";

            SqlCommand c = new SqlCommand(q2, con);
            string tc = Convert.ToString(c.ExecuteScalar());
            con.Close();
            if (int.Parse(lblRMAmt.Text) != 0)
            {
                if (tc.IsNullOrWhiteSpace())
                {
                    MessageBox.Show("PLEASE ADD NOMINEE ....!");
                    dgcart.Rows.Clear();
                    clrall();

                }

                else
                {
                    con.Open();
                    if (dgcart.RowCount == 0)
                    {
                        MessageBox.Show("ADD PRODUCT YOUR PRODUCT IN CART");
                    }
                    else if (txtPAmt.Text == "")
                    {
                        MessageBox.Show("ENTER PAYING AMOUNT..! ");
                    }
                    else
                    {


                        DateTime currentDate = DateTime.Now;
                        string dateString = currentDate.ToString("yyyy-MM-dd");

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

                        con.Close();

                        con.Open();
                        //Product going in MpBills
                        string cmd1 = "SELECT MAX(BillId) FROM Bill";
                        SqlCommand command = new SqlCommand(cmd1, con);

                        int lastId = Convert.ToInt32(command.ExecuteScalar());
                        con.Close();
                        fillExp(lastId);
                        con.Open();
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
                        con.Close();
                        gpdf(lastId.ToString());
                        populateproduct();
                        clrall();

                    }

                }
                con.Close();
            }
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

        }



        private void btnAdCrt_Click(object sender, EventArgs e)
        {

            con.Open();
            string query = "select stockQuantity from Product where ProductId='" + txtpid.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            //cmd.ExecuteNonQuery();
            object result = cmd.ExecuteScalar();
            int Stockquant = Convert.ToInt32(result);
            if (txtCID.Text == "" || txtQnty.Text == "" || txtCName.Text == "" || txtPName.Text == "" || txtpp.Text == "" || txtpid.Text == "")
            {
                MessageBox.Show("INFORMATION MISSING\n Please enter complete information");

            }
            else if (int.Parse(txtQnty.Text) > Stockquant)
            {
                MessageBox.Show("NOT ENOUGH PRODUCTS IN STOCK..!");
            }
            else if(int.Parse(txtQnty.Text)==0)
            {
                MessageBox.Show("INVALID QUANTITY");
                txtQnty.Focus();
            }
            else
            {

                DateTime currentDate = DateTime.Now;
                string dateString = currentDate.ToString("yyyy-MM-dd");

                string pid = txtpid.Text;
                string pn = txtPName.Text;
                int q = int.Parse(txtQnty.Text);
                int pp = int.Parse(txtpp.Text);
                string cid = txtCID.Text;
                string cn = txtCName.Text;
                int totalp = q * pp;
                string[] row = new string[] { pid, pn, q.ToString(), totalp.ToString() };
                dgcart.Rows.Add(row);


                totalamt = totalp + totalamt;
                lblTAmt.Text = totalamt.ToString();

                txtpid.Text = "";
                txtPName.Text = "";

            }
            con.Close();
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


        private void button5_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtPAmt.Text) <= int.Parse(lblTAmt.Text) && int.Parse(txtPAmt.Text) > 0)
            {
                int ttl = int.Parse(lblTAmt.Text);
                int pamt = int.Parse(txtPAmt.Text);
                int r = ttl - pamt;
                lblRMAmt.Text = r.ToString();
            }
            else
            {
                MessageBox.Show("ENTER VALID AMOUNT");
            }
        }


        private void txtCID_TextChanged(object sender, EventArgs e)
        {
            if (txtCID.Text.Length > 0)
            {
                con.Open();
                string q2 = "select SUM(TotalAmount-PaidAmount) from bill where PaymentStatus='Half' AND CustomerId='" + txtCID.Text + "'";

                SqlCommand command = new SqlCommand(q2, con);
                string tc = Convert.ToString(command.ExecuteScalar());
                lblTC.Text = tc.ToString();
                if (lblTC.Text == "")
                {
                    lblTC.Text = "0";
                }
                con.Close();
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
            var t = new Total();
            t.Show();
        }
    }
}
