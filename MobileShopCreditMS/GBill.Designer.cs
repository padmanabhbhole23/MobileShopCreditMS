namespace MobileShopCreditMS
{
    partial class GBill
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel2 = new Panel();
            button3 = new Button();
            btnView = new Button();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            cbCName = new ComboBox();
            txtCID = new TextBox();
            label6 = new Label();
            label4 = new Label();
            btnAdCrt = new Button();
            txtpp = new TextBox();
            label5 = new Label();
            txtQnty = new TextBox();
            label1 = new Label();
            combPName = new ComboBox();
            label12 = new Label();
            combPTYPE = new ComboBox();
            label13 = new Label();
            btnGBill = new Button();
            label3 = new Label();
            button1 = new Button();
            gBillBindingSource = new BindingSource(components);
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            label7 = new Label();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gBillBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(button3);
            panel2.Controls.Add(btnView);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 737);
            panel2.TabIndex = 4;
            // 
            // button3
            // 
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button3.Location = new Point(5, 185);
            button3.Name = "button3";
            button3.Size = new Size(209, 43);
            button3.TabIndex = 4;
            button3.Text = "VIEW CATALOGUE";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnView
            // 
            btnView.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnView.Location = new Point(5, 126);
            btnView.Name = "btnView";
            btnView.Size = new Size(209, 43);
            btnView.TabIndex = 3;
            btnView.Text = "ADD CUSTOMERS";
            btnView.UseVisualStyleBackColor = true;
            btnView.Click += btnView_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Rounded MT Bold", 23F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(5, 23);
            label2.Name = "label2";
            label2.Size = new Size(226, 38);
            label2.TabIndex = 2;
            label2.Text = "PHONE LINK";
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.AppStarting;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(5, 93);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(116, 27);
            button2.TabIndex = 0;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.AllowDrop = true;
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Bisque;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dataGridView1);
            panel1.Controls.Add(cbCName);
            panel1.Controls.Add(txtCID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAdCrt);
            panel1.Controls.Add(txtpp);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtQnty);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(combPName);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(combPTYPE);
            panel1.Controls.Add(label13);
            panel1.Controls.Add(btnGBill);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.ForeColor = Color.Maroon;
            panel1.Location = new Point(242, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 737);
            panel1.TabIndex = 5;
            panel1.Paint += panel1_Paint;
            // 
            // cbCName
            // 
            cbCName.FormattingEnabled = true;
            cbCName.Location = new Point(237, 382);
            cbCName.Margin = new Padding(4, 3, 4, 3);
            cbCName.Name = "cbCName";
            cbCName.Size = new Size(208, 23);
            cbCName.TabIndex = 37;
            // 
            // txtCID
            // 
            txtCID.Location = new Point(237, 322);
            txtCID.Margin = new Padding(4, 3, 4, 3);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(116, 23);
            txtCID.TabIndex = 36;
            txtCID.TextChanged += txtCID_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(53, 382);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(132, 19);
            label6.TabIndex = 35;
            label6.Text = "CUSTOMER NAME";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(53, 322);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 19);
            label4.TabIndex = 34;
            label4.Text = "CUSTOMER ID";
            // 
            // btnAdCrt
            // 
            btnAdCrt.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnAdCrt.ForeColor = SystemColors.ControlText;
            btnAdCrt.Location = new Point(110, 618);
            btnAdCrt.Margin = new Padding(4, 3, 4, 3);
            btnAdCrt.Name = "btnAdCrt";
            btnAdCrt.Size = new Size(209, 43);
            btnAdCrt.TabIndex = 33;
            btnAdCrt.Text = "ADD TO CART";
            btnAdCrt.UseVisualStyleBackColor = true;
            btnAdCrt.Click += btnAdCrt_Click;
            // 
            // txtpp
            // 
            txtpp.Location = new Point(237, 266);
            txtpp.Margin = new Padding(4, 3, 4, 3);
            txtpp.Name = "txtpp";
            txtpp.Size = new Size(116, 23);
            txtpp.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(53, 266);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 31;
            label5.Text = "PRODUCT PRICE";
            // 
            // txtQnty
            // 
            txtQnty.Location = new Point(237, 209);
            txtQnty.Margin = new Padding(4, 3, 4, 3);
            txtQnty.Name = "txtQnty";
            txtQnty.Size = new Size(116, 23);
            txtQnty.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(53, 209);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 29;
            label1.Text = "PRODUCT QUANTITY";
            // 
            // combPName
            // 
            combPName.FormattingEnabled = true;
            combPName.Location = new Point(237, 162);
            combPName.Margin = new Padding(4, 3, 4, 3);
            combPName.Name = "combPName";
            combPName.Size = new Size(208, 23);
            combPName.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(53, 162);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(121, 19);
            label12.TabIndex = 27;
            label12.Text = "PRODUCT NAME";
            // 
            // combPTYPE
            // 
            combPTYPE.FormattingEnabled = true;
            combPTYPE.Items.AddRange(new object[] { "MOBILE PHONE", "ACCESSORIES", "OTHER" });
            combPTYPE.Location = new Point(237, 110);
            combPTYPE.Margin = new Padding(4, 3, 4, 3);
            combPTYPE.Name = "combPTYPE";
            combPTYPE.Size = new Size(208, 23);
            combPTYPE.TabIndex = 26;
            combPTYPE.SelectedIndexChanged += combPTYPE_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label13.ForeColor = SystemColors.ActiveCaptionText;
            label13.Location = new Point(53, 110);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(162, 19);
            label13.TabIndex = 25;
            label13.Text = "SELECT PRODUCT TYPE";
            // 
            // btnGBill
            // 
            btnGBill.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnGBill.ForeColor = SystemColors.ActiveCaptionText;
            btnGBill.Location = new Point(380, 618);
            btnGBill.Name = "btnGBill";
            btnGBill.Size = new Size(209, 43);
            btnGBill.TabIndex = 24;
            btnGBill.Text = "GENERATE BILL";
            btnGBill.UseVisualStyleBackColor = true;
            btnGBill.Click += btnGBill_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(26, 23);
            label3.Name = "label3";
            label3.Size = new Size(246, 34);
            label3.TabIndex = 23;
            label3.Text = "GENERATE BILL";
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(990, 20);
            button1.Name = "button1";
            button1.Size = new Size(114, 37);
            button1.TabIndex = 0;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // gBillBindingSource
            // 
            gBillBindingSource.DataSource = typeof(GBill);
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridView1.Location = new Point(548, 110);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(542, 340);
            dataGridView1.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(813, 88);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 19);
            label7.TabIndex = 39;
            label7.Text = "BILL";
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "ITEM NAME";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "PRICE";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "QUANTITY";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "TOTAL";
            Column5.Name = "Column5";
            // 
            // GBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1366, 749);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "GBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GBill";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gBillBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Button button3;
        private Button btnView;
        private Label label2;
        private Button button2;
        private Panel panel1;
        private Label label3;
        private Button button1;
        private Button btnGBill;
        private ComboBox cbCName;
        private TextBox txtCID;
        private Label label6;
        private Label label4;
        private Button btnAdCrt;
        private TextBox txtpp;
        private Label label5;
        private TextBox txtQnty;
        private Label label1;
        private ComboBox combPName;
        private Label label12;
        private ComboBox combPTYPE;
        private Label label13;
        private BindingSource gBillBindingSource;
        private BindingSource bindingSource1;
        private Label label7;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}