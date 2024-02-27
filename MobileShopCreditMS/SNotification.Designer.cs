namespace MobileShopCreditMS
{
    partial class SNotification
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SNotification));
            button1 = new Button();
            button3 = new Button();
            label3 = new Label();
            smspanel = new Panel();
            label5 = new Label();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            whtsppanel = new Panel();
            btnwhtssms = new Button();
            label7 = new Label();
            txtcustmob = new TextBox();
            txtwtxt = new TextBox();
            label8 = new Label();
            rbsms = new RadioButton();
            rbwhatsapp = new RadioButton();
            label4 = new Label();
            label6 = new Label();
            custgview = new DataGridView();
            txtSearch = new TextBox();
            label2 = new Label();
            smspanel.SuspendLayout();
            whtsppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)custgview).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.AppStarting;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(12, 111);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(116, 27);
            button1.TabIndex = 25;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.White;
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button3.ForeColor = SystemColors.ActiveCaptionText;
            button3.Location = new Point(1199, 35);
            button3.Name = "button3";
            button3.Size = new Size(114, 37);
            button3.TabIndex = 26;
            button3.Text = "EXIT";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.FixedSingle;
            label3.Font = new Font("Arial Rounded MT Bold", 23F, FontStyle.Bold);
            label3.ForeColor = Color.Maroon;
            label3.Location = new Point(12, 21);
            label3.Name = "label3";
            label3.Size = new Size(226, 38);
            label3.TabIndex = 27;
            label3.Text = "PHONE LINK";
            // 
            // smspanel
            // 
            smspanel.Controls.Add(label5);
            smspanel.Controls.Add(button2);
            smspanel.Controls.Add(textBox2);
            smspanel.Controls.Add(textBox1);
            smspanel.Controls.Add(label1);
            smspanel.Location = new Point(196, 317);
            smspanel.Name = "smspanel";
            smspanel.Size = new Size(508, 367);
            smspanel.TabIndex = 28;
            smspanel.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(8, 88);
            label5.Name = "label5";
            label5.Size = new Size(156, 19);
            label5.TabIndex = 9;
            label5.Text = "CUSTOMER SMS TEXT";
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button2.Location = new Point(138, 299);
            button2.Name = "button2";
            button2.Size = new Size(209, 43);
            button2.TabIndex = 8;
            button2.Text = "SEND SMS";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 35);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(208, 23);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 88);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(298, 137);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(8, 35);
            label1.Name = "label1";
            label1.Size = new Size(172, 19);
            label1.TabIndex = 5;
            label1.Text = "CUSTOMER MOBILE NO.";
            // 
            // whtsppanel
            // 
            whtsppanel.Controls.Add(btnwhtssms);
            whtsppanel.Controls.Add(label7);
            whtsppanel.Controls.Add(txtcustmob);
            whtsppanel.Controls.Add(txtwtxt);
            whtsppanel.Controls.Add(label8);
            whtsppanel.Location = new Point(710, 317);
            whtsppanel.Name = "whtsppanel";
            whtsppanel.Size = new Size(508, 367);
            whtsppanel.TabIndex = 29;
            whtsppanel.Visible = false;
            // 
            // btnwhtssms
            // 
            btnwhtssms.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnwhtssms.Location = new Point(160, 299);
            btnwhtssms.Name = "btnwhtssms";
            btnwhtssms.Size = new Size(209, 43);
            btnwhtssms.TabIndex = 14;
            btnwhtssms.Text = "SEND WHATSAPP MESSAGE";
            btnwhtssms.UseVisualStyleBackColor = true;
            btnwhtssms.Click += btnwhtssms_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.ForeColor = Color.Maroon;
            label7.Location = new Point(8, 88);
            label7.Name = "label7";
            label7.Size = new Size(156, 19);
            label7.TabIndex = 13;
            label7.Text = "CUSTOMER SMS TEXT";
            // 
            // txtcustmob
            // 
            txtcustmob.Location = new Point(192, 35);
            txtcustmob.Name = "txtcustmob";
            txtcustmob.Size = new Size(208, 23);
            txtcustmob.TabIndex = 12;
            // 
            // txtwtxt
            // 
            txtwtxt.Location = new Point(192, 88);
            txtwtxt.Multiline = true;
            txtwtxt.Name = "txtwtxt";
            txtwtxt.Size = new Size(298, 137);
            txtwtxt.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(8, 39);
            label8.Name = "label8";
            label8.Size = new Size(172, 19);
            label8.TabIndex = 10;
            label8.Text = "CUSTOMER MOBILE NO.";
            // 
            // rbsms
            // 
            rbsms.AutoSize = true;
            rbsms.Font = new Font("Calibri", 12F, FontStyle.Bold);
            rbsms.Location = new Point(435, 288);
            rbsms.Name = "rbsms";
            rbsms.Size = new Size(57, 23);
            rbsms.TabIndex = 30;
            rbsms.TabStop = true;
            rbsms.Text = "SMS";
            rbsms.UseVisualStyleBackColor = true;
            rbsms.Click += rbsms_Click;
            // 
            // rbwhatsapp
            // 
            rbwhatsapp.AutoSize = true;
            rbwhatsapp.Font = new Font("Calibri", 12F, FontStyle.Bold);
            rbwhatsapp.Location = new Point(922, 290);
            rbwhatsapp.Name = "rbwhatsapp";
            rbwhatsapp.Size = new Size(105, 23);
            rbwhatsapp.TabIndex = 31;
            rbwhatsapp.TabStop = true;
            rbwhatsapp.Text = "WHATSAPP";
            rbwhatsapp.UseVisualStyleBackColor = true;
            rbwhatsapp.Click += rbwhatsapp_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.Location = new Point(196, 292);
            label4.Name = "label4";
            label4.Size = new Size(173, 19);
            label4.TabIndex = 32;
            label4.Text = "SEND NOTIFICATION VIA";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.Location = new Point(204, 158);
            label6.Name = "label6";
            label6.Size = new Size(136, 19);
            label6.TabIndex = 33;
            label6.Text = "SELECT CUSTOMER";
            // 
            // custgview
            // 
            custgview.AllowUserToAddRows = false;
            custgview.AllowUserToDeleteRows = false;
            custgview.BackgroundColor = SystemColors.GradientActiveCaption;
            custgview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custgview.Location = new Point(346, 158);
            custgview.Name = "custgview";
            custgview.ReadOnly = true;
            custgview.Size = new Size(627, 106);
            custgview.TabIndex = 34;
            custgview.CellContentClick += custgview_CellContentClick;
            custgview.MouseDoubleClick += custgview_MouseDoubleClick;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(348, 129);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(208, 23);
            txtSearch.TabIndex = 35;
            txtSearch.TextChanged += textBox3_TextChanged;
            txtSearch.KeyPress += txtSearch_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(256, 25);
            label2.Name = "label2";
            label2.Size = new Size(314, 34);
            label2.TabIndex = 5;
            label2.Text = "SEND NOTIFICATION";
            // 
            // SNotification
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1366, 749);
            Controls.Add(txtSearch);
            Controls.Add(custgview);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(rbwhatsapp);
            Controls.Add(whtsppanel);
            Controls.Add(smspanel);
            Controls.Add(rbsms);
            Controls.Add(label3);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "SNotification";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SNotification";
            smspanel.ResumeLayout(false);
            smspanel.PerformLayout();
            whtsppanel.ResumeLayout(false);
            whtsppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)custgview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button3;
        private Label label3;
        private Panel smspanel;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label1;
        private Panel whtsppanel;
        private RadioButton rbsms;
        private RadioButton rbwhatsapp;
        private Label label4;
        private Label label5;
        private Label label7;
        private TextBox txtcustmob;
        private TextBox txtwtxt;
        private Label label8;
        private Label label6;
        private Button btnwhtssms;
        private DataGridView custgview;
        private TextBox txtSearch;
        private Label label2;
    }
}