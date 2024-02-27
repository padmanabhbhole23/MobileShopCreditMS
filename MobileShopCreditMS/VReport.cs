using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Excel;
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

namespace MobileShopCreditMS
{
    public partial class VReport : Form
    {
        public VReport()
        {
            InitializeComponent();
            /*Padma*/
            SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=project;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
            //affan
            //SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\SAMSUNG\Documents\project.mdf;Integrated Security=True;Connect Timeout=30");

            con.Open();
            string query = "select c.FirstName,c.MidName,c.LastName, b.* FROM Customer c JOIN bill b ON c.customerId=b.customerId";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgexport.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var v = new ADash();
            this.Close();
            v.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                sfd.FileName = "SalesReport_" + DateTime.Now.ToString("yyyyMMdd_HHmmss");
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("ExportedData");

                            // Write column headers
                            for (int i = 0; i < dgexport.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dgexport.Columns[i].HeaderText;
                            }

                            // Write data
                            for (int i = 0; i < dgexport.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgexport.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dgexport.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            workbook.SaveAs(sfd.FileName);
                            MessageBox.Show("You have successfully exported your data to " + sfd.FileName, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
