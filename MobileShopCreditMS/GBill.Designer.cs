﻿namespace MobileShopCreditMS
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
            panel2 = new Panel();
            button3 = new Button();
            btnView = new Button();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            txtPName = new TextBox();
            lblTAmt = new Label();
            label15 = new Label();
            lblRMAmt = new Label();
            label11 = new Label();
            txtCName = new TextBox();
            txtPAmt = new TextBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            dgproduct = new DataGridView();
            dgcust = new DataGridView();
            label7 = new Label();
            dgcart = new DataGridView();
            txtCID = new TextBox();
            label6 = new Label();
            label4 = new Label();
            btnAdCrt = new Button();
            txtpp = new TextBox();
            label5 = new Label();
            txtQnty = new TextBox();
            label1 = new Label();
            label12 = new Label();
            btnGBill = new Button();
            label3 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgproduct).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgcust).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgcart).BeginInit();
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
            panel1.Controls.Add(txtPName);
            panel1.Controls.Add(lblTAmt);
            panel1.Controls.Add(label15);
            panel1.Controls.Add(lblRMAmt);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(txtCName);
            panel1.Controls.Add(txtPAmt);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(dgproduct);
            panel1.Controls.Add(dgcust);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dgcart);
            panel1.Controls.Add(txtCID);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btnAdCrt);
            panel1.Controls.Add(txtpp);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txtQnty);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label12);
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
            // txtPName
            // 
            txtPName.Location = new Point(216, 104);
            txtPName.Margin = new Padding(4, 3, 4, 3);
            txtPName.Name = "txtPName";
            txtPName.Size = new Size(200, 23);
            txtPName.TabIndex = 51;
            // 
            // lblTAmt
            // 
            lblTAmt.AutoSize = true;
            lblTAmt.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblTAmt.ForeColor = SystemColors.ControlText;
            lblTAmt.Location = new Point(754, 365);
            lblTAmt.Margin = new Padding(4, 0, 4, 0);
            lblTAmt.Name = "lblTAmt";
            lblTAmt.Size = new Size(41, 19);
            lblTAmt.TabIndex = 50;
            lblTAmt.Text = "0.0/-";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label15.ForeColor = SystemColors.ControlText;
            label15.Location = new Point(595, 365);
            label15.Margin = new Padding(4, 0, 4, 0);
            label15.Name = "label15";
            label15.Size = new Size(120, 19);
            label15.TabIndex = 49;
            label15.Text = "TOTAL AMOUNT";
            // 
            // lblRMAmt
            // 
            lblRMAmt.AutoSize = true;
            lblRMAmt.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblRMAmt.ForeColor = SystemColors.ControlText;
            lblRMAmt.Location = new Point(216, 365);
            lblRMAmt.Margin = new Padding(4, 0, 4, 0);
            lblRMAmt.Name = "lblRMAmt";
            lblRMAmt.Size = new Size(41, 19);
            lblRMAmt.TabIndex = 48;
            lblRMAmt.Text = "0.0/-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label11.ForeColor = SystemColors.ControlText;
            label11.Location = new Point(32, 365);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(158, 19);
            label11.TabIndex = 47;
            label11.Text = "REMAINING AMOUNT";
            // 
            // txtCName
            // 
            txtCName.Location = new Point(216, 273);
            txtCName.Margin = new Padding(4, 3, 4, 3);
            txtCName.Name = "txtCName";
            txtCName.Size = new Size(200, 23);
            txtCName.TabIndex = 46;
            // 
            // txtPAmt
            // 
            txtPAmt.Location = new Point(216, 319);
            txtPAmt.Margin = new Padding(4, 3, 4, 3);
            txtPAmt.Name = "txtPAmt";
            txtPAmt.Size = new Size(200, 23);
            txtPAmt.TabIndex = 45;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlText;
            label10.Location = new Point(32, 319);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(157, 19);
            label10.TabIndex = 44;
            label10.Text = "TOTAL PIAD AMOUNT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlText;
            label9.Location = new Point(39, 487);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(146, 19);
            label9.TabIndex = 43;
            label9.Text = "SEARCH CUSTOMER ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(584, 487);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(131, 19);
            label8.TabIndex = 42;
            label8.Text = "SEARCH PRODUCT";
            // 
            // dgproduct
            // 
            dgproduct.AllowUserToAddRows = false;
            dgproduct.AllowUserToDeleteRows = false;
            dgproduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgproduct.Location = new Point(584, 509);
            dgproduct.Name = "dgproduct";
            dgproduct.ReadOnly = true;
            dgproduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgproduct.Size = new Size(470, 202);
            dgproduct.TabIndex = 41;
            dgproduct.CellContentClick += dgproduct_CellContentClick;
            // 
            // dgcust
            // 
            dgcust.AllowUserToAddRows = false;
            dgcust.AllowUserToDeleteRows = false;
            dgcust.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgcust.Location = new Point(39, 509);
            dgcust.Name = "dgcust";
            dgcust.ReadOnly = true;
            dgcust.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgcust.Size = new Size(470, 202);
            dgcust.TabIndex = 40;
            dgcust.CellContentClick += dgcust_CellContentClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ActiveCaptionText;
            label7.Location = new Point(790, 71);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(44, 19);
            label7.TabIndex = 39;
            label7.Text = "CART";
            // 
            // dgcart
            // 
            dgcart.AllowUserToDeleteRows = false;
            dgcart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgcart.Location = new Point(546, 93);
            dgcart.Name = "dgcart";
            dgcart.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgcart.Size = new Size(530, 252);
            dgcart.TabIndex = 38;
            // 
            // txtCID
            // 
            txtCID.Location = new Point(216, 232);
            txtCID.Margin = new Padding(4, 3, 4, 3);
            txtCID.Name = "txtCID";
            txtCID.Size = new Size(200, 23);
            txtCID.TabIndex = 36;
            txtCID.TextChanged += txtCID_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(32, 273);
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
            label4.Location = new Point(32, 232);
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
            btnAdCrt.Location = new Point(140, 417);
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
            txtpp.Location = new Point(216, 193);
            txtpp.Margin = new Padding(4, 3, 4, 3);
            txtpp.Name = "txtpp";
            txtpp.Size = new Size(200, 23);
            txtpp.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.ForeColor = SystemColors.ActiveCaptionText;
            label5.Location = new Point(32, 197);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(116, 19);
            label5.TabIndex = 31;
            label5.Text = "PRODUCT PRICE";
            // 
            // txtQnty
            // 
            txtQnty.Location = new Point(216, 151);
            txtQnty.Margin = new Padding(4, 3, 4, 3);
            txtQnty.Name = "txtQnty";
            txtQnty.Size = new Size(200, 23);
            txtQnty.TabIndex = 30;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(32, 151);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 19);
            label1.TabIndex = 29;
            label1.Text = "PRODUCT QUANTITY";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label12.ForeColor = SystemColors.ActiveCaptionText;
            label12.Location = new Point(32, 104);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(121, 19);
            label12.TabIndex = 27;
            label12.Text = "PRODUCT NAME";
            // 
            // btnGBill
            // 
            btnGBill.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnGBill.ForeColor = SystemColors.ActiveCaptionText;
            btnGBill.Location = new Point(699, 417);
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
            ((System.ComponentModel.ISupportInitialize)dgproduct).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgcust).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgcart).EndInit();
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
        private TextBox txtCID;
        private Label label6;
        private Label label4;
        private Button btnAdCrt;
        private TextBox txtpp;
        private Label label5;
        private TextBox txtQnty;
        private Label label1;
        private Label label12;
        private Label label7;
        private DataGridView dgcart;
        private DataGridView dgcust;
        private Label label9;
        private Label label8;
        private DataGridView dgproduct;
        private Label label10;
        private Label lblRMAmt;
        private Label label11;
        private TextBox txtCName;
        private TextBox txtPAmt;
        private Label label15;
        private Label lblTAmt;
        private TextBox txtPName;
    }
}