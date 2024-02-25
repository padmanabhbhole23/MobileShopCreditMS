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
            panel2 = new Panel();
            button3 = new Button();
            btnView = new Button();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            btnGBill = new Button();
            label3 = new Label();
            button1 = new Button();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
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
            // btnGBill
            // 
            btnGBill.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnGBill.ForeColor = SystemColors.ActiveCaptionText;
            btnGBill.Location = new Point(82, 655);
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
    }
}