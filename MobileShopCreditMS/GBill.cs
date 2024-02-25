using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace MobileShopCreditMS
{
    public partial class GBill : Form
    {
        public GBill()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
