﻿namespace MobileShopCreditMS
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
            custgview = new DataGridView();
            label2 = new Label();
            label6 = new Label();
            label9 = new Label();
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
            button1.Location = new Point(14, 141);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(133, 34);
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
            button3.Location = new Point(1370, 44);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(130, 47);
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
            label3.Location = new Point(14, 27);
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
            smspanel.Location = new Point(210, 424);
            smspanel.Margin = new Padding(3, 4, 3, 4);
            smspanel.Name = "smspanel";
            smspanel.Size = new Size(581, 312);
            smspanel.TabIndex = 28;
            smspanel.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.ForeColor = Color.Maroon;
            label5.Location = new Point(3, 78);
            label5.Name = "label5";
            label5.Size = new Size(156, 19);
            label5.TabIndex = 9;
            label5.Text = "CUSTOMER SMS TEXT";
            // 
            // button2
            // 
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button2.Location = new Point(213, 252);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(239, 54);
            button2.TabIndex = 8;
            button2.Text = "SEND SMS";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 11);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(237, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 78);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(340, 166);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(3, 11);
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
            whtsppanel.Location = new Point(797, 424);
            whtsppanel.Margin = new Padding(3, 4, 3, 4);
            whtsppanel.Name = "whtsppanel";
            whtsppanel.Size = new Size(546, 312);
            whtsppanel.TabIndex = 29;
            whtsppanel.Visible = false;
            // 
            // btnwhtssms
            // 
            btnwhtssms.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnwhtssms.Location = new Point(188, 249);
            btnwhtssms.Margin = new Padding(3, 4, 3, 4);
            btnwhtssms.Name = "btnwhtssms";
            btnwhtssms.Size = new Size(239, 54);
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
            label7.Location = new Point(3, 81);
            label7.Name = "label7";
            label7.Size = new Size(156, 19);
            label7.TabIndex = 13;
            label7.Text = "CUSTOMER SMS TEXT";
            // 
            // txtcustmob
            // 
            txtcustmob.Location = new Point(190, 11);
            txtcustmob.Margin = new Padding(3, 4, 3, 4);
            txtcustmob.Name = "txtcustmob";
            txtcustmob.Size = new Size(237, 27);
            txtcustmob.TabIndex = 12;
            // 
            // txtwtxt
            // 
            txtwtxt.Location = new Point(190, 78);
            txtwtxt.Margin = new Padding(3, 4, 3, 4);
            txtwtxt.Multiline = true;
            txtwtxt.Name = "txtwtxt";
            txtwtxt.Size = new Size(340, 166);
            txtwtxt.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.ForeColor = Color.Maroon;
            label8.Location = new Point(3, 19);
            label8.Name = "label8";
            label8.Size = new Size(172, 19);
            label8.TabIndex = 10;
            label8.Text = "CUSTOMER MOBILE NO.";
            // 
            // rbsms
            // 
            rbsms.AutoSize = true;
            rbsms.Font = new Font("Calibri", 12F, FontStyle.Bold);
            rbsms.Location = new Point(483, 383);
            rbsms.Margin = new Padding(3, 4, 3, 4);
            rbsms.Name = "rbsms";
            rbsms.Size = new Size(57, 23);
            rbsms.TabIndex = 30;
            rbsms.TabStop = true;
            rbsms.Text = "SMS";
            rbsms.UseVisualStyleBackColor = true;
            rbsms.CheckedChanged += rbsms_CheckedChanged;
            rbsms.Click += rbsms_Click;
            // 
            // rbwhatsapp
            // 
            rbwhatsapp.AutoSize = true;
            rbwhatsapp.Font = new Font("Calibri", 12F, FontStyle.Bold);
            rbwhatsapp.Location = new Point(1040, 385);
            rbwhatsapp.Margin = new Padding(3, 4, 3, 4);
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
            label4.Location = new Point(210, 388);
            label4.Name = "label4";
            label4.Size = new Size(173, 19);
            label4.TabIndex = 32;
            label4.Text = "SEND NOTIFICATION VIA";
            label4.Click += label4_Click;
            // 
            // custgview
            // 
            custgview.AllowUserToAddRows = false;
            custgview.AllowUserToDeleteRows = false;
            custgview.BackgroundColor = SystemColors.GradientActiveCaption;
            custgview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            custgview.Location = new Point(275, 92);
            custgview.Margin = new Padding(3, 4, 3, 4);
            custgview.Name = "custgview";
            custgview.ReadOnly = true;
            custgview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            custgview.Size = new Size(1042, 283);
            custgview.TabIndex = 34;
            custgview.CellContentClick += custgview_CellContentClick;
            custgview.MouseDoubleClick += custgview_MouseDoubleClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(293, 32);
            label2.Name = "label2";
            label2.Size = new Size(314, 34);
            label2.TabIndex = 5;
            label2.Text = "SEND NOTIFICATION";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.Location = new Point(184, 149);
            label6.Name = "label6";
            label6.Size = new Size(56, 19);
            label6.TabIndex = 33;
            label6.Text = "SELECT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label9.Location = new Point(184, 172);
            label9.Name = "label9";
            label9.Size = new Size(85, 19);
            label9.TabIndex = 35;
            label9.Text = "CUSTOMER";
            // 
            // SNotification
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1370, 749);
            Controls.Add(label9);
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
            Font = new Font("Calibri", 12F, FontStyle.Bold);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
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
        private Button btnwhtssms;
        private DataGridView custgview;
        private Label label2;
        private Label label6;
        private Label label9;
    }
}