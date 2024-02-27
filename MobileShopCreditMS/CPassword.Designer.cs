namespace MobileShopCreditMS
{
    partial class CPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CPassword));
            panel1 = new Panel();
            label5 = new Label();
            button1 = new Button();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            button2 = new Button();
            lblName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(lblName);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(603, 551);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BorderStyle = BorderStyle.FixedSingle;
            label5.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(141, 87);
            label5.Name = "label5";
            label5.Size = new Size(316, 34);
            label5.TabIndex = 14;
            label5.Text = "CHANGE PASSWORD";
            // 
            // button1
            // 
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.Location = new Point(223, 402);
            button1.Name = "button1";
            button1.Size = new Size(209, 43);
            button1.TabIndex = 13;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(303, 323);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(148, 23);
            textBox4.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.Location = new Point(123, 327);
            label4.Name = "label4";
            label4.Size = new Size(156, 19);
            label4.TabIndex = 11;
            label4.Text = "CONFIRM PASSWORD";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(303, 270);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(148, 23);
            textBox3.TabIndex = 10;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 215);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 23);
            textBox2.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.Location = new Point(150, 274);
            label3.Name = "label3";
            label3.Size = new Size(126, 19);
            label3.TabIndex = 8;
            label3.Text = "NEW PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label2.Location = new Point(123, 215);
            label2.Name = "label2";
            label2.Size = new Size(155, 19);
            label2.TabIndex = 7;
            label2.Text = "CURRENT PASSWORD";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 167);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 23);
            textBox1.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(189, 171);
            label1.Name = "label1";
            label1.Size = new Size(87, 19);
            label1.TabIndex = 5;
            label1.Text = "USERNAME";
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.AppStarting;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(11, 3);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(77, 30);
            button2.TabIndex = 4;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Font = new Font("Arial Rounded MT Bold", 23F, FontStyle.Bold);
            lblName.ForeColor = Color.Maroon;
            lblName.Location = new Point(189, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(226, 38);
            lblName.TabIndex = 3;
            lblName.Text = "PHONE LINK";
            // 
            // CPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(606, 548);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "CPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CPassword";
            Load += CPassword_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblName;
        private Button button2;
        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private Label label5;
    }
}