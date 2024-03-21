namespace MobileShopCreditMS
{
    partial class Total
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Total));
            panel1 = new Panel();
            label8 = new Label();
            lblTC = new Label();
            label3 = new Label();
            AddBtn = new Button();
            EDITPANEL = new Panel();
            label7 = new Label();
            button1 = new Button();
            label6 = new Label();
            textBox2 = new TextBox();
            label5 = new Label();
            button3 = new Button();
            label4 = new Label();
            textBox1 = new TextBox();
            txtET = new TextBox();
            lblAmt = new Label();
            label1 = new Label();
            lblType = new Label();
            DGTTL = new DataGridView();
            button2 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            EDITPANEL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGTTL).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(lblTC);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(AddBtn);
            panel1.Controls.Add(EDITPANEL);
            panel1.Controls.Add(DGTTL);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1357, 742);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.Location = new Point(970, 59);
            label8.Name = "label8";
            label8.Size = new Size(186, 19);
            label8.TabIndex = 26;
            label8.Text = "TOTAL PENDING CREDITS :";
            // 
            // lblTC
            // 
            lblTC.AutoSize = true;
            lblTC.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblTC.ForeColor = Color.Red;
            lblTC.Location = new Point(1191, 59);
            lblTC.Name = "lblTC";
            lblTC.Size = new Size(17, 19);
            lblTC.TabIndex = 25;
            lblTC.Text = "0";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(275, 23);
            label3.Name = "label3";
            label3.Size = new Size(277, 34);
            label3.TabIndex = 24;
            label3.Text = "MANAGE CREDITS";
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(275, 346);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(210, 44);
            AddBtn.TabIndex = 22;
            AddBtn.Text = "UPDATE";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // EDITPANEL
            // 
            EDITPANEL.Controls.Add(label7);
            EDITPANEL.Controls.Add(button1);
            EDITPANEL.Controls.Add(label6);
            EDITPANEL.Controls.Add(textBox2);
            EDITPANEL.Controls.Add(label5);
            EDITPANEL.Controls.Add(button3);
            EDITPANEL.Controls.Add(label4);
            EDITPANEL.Controls.Add(textBox1);
            EDITPANEL.Controls.Add(txtET);
            EDITPANEL.Controls.Add(lblAmt);
            EDITPANEL.Controls.Add(label1);
            EDITPANEL.Controls.Add(lblType);
            EDITPANEL.Location = new Point(275, 415);
            EDITPANEL.Name = "EDITPANEL";
            EDITPANEL.Size = new Size(693, 290);
            EDITPANEL.TabIndex = 8;
            EDITPANEL.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.Location = new Point(299, 246);
            label7.Name = "label7";
            label7.Size = new Size(51, 19);
            label7.TabIndex = 31;
            label7.Text = "OK -->";
            label7.Click += label7_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(250, 145);
            button1.Name = "button1";
            button1.Size = new Size(132, 33);
            button1.TabIndex = 30;
            button1.Text = "Confirm Amount";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.Location = new Point(26, 224);
            label6.Name = "label6";
            label6.Size = new Size(115, 19);
            label6.TabIndex = 29;
            label6.Text = "Enter Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(204, 220);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(223, 23);
            textBox2.TabIndex = 28;
            textBox2.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.Location = new Point(26, 99);
            label5.Name = "label5";
            label5.Size = new Size(106, 38);
            label5.TabIndex = 26;
            label5.Text = "Enter Amount\r\n\r\n";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(433, 11);
            button3.Name = "button3";
            button3.Size = new Size(57, 23);
            button3.TabIndex = 25;
            button3.Text = "OK";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(221, 55);
            label4.Name = "label4";
            label4.Size = new Size(29, 19);
            label4.TabIndex = 24;
            label4.Text = "0.0";
            label4.Click += label4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 13;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtET
            // 
            txtET.Location = new Point(204, 99);
            txtET.Name = "txtET";
            txtET.Size = new Size(223, 23);
            txtET.TabIndex = 13;
            txtET.TextChanged += txtET_TextChanged;
            // 
            // lblAmt
            // 
            lblAmt.AutoSize = true;
            lblAmt.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblAmt.Location = new Point(26, 55);
            lblAmt.Name = "lblAmt";
            lblAmt.Size = new Size(158, 19);
            lblAmt.TabIndex = 11;
            lblAmt.Text = "REMAINING AMOUNT";
            lblAmt.Click += lblAmt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(26, 11);
            label1.Name = "label1";
            label1.Size = new Size(54, 19);
            label1.TabIndex = 10;
            label1.Text = "BILL ID";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblType.Location = new Point(275, 19);
            lblType.Name = "lblType";
            lblType.Size = new Size(107, 19);
            lblType.TabIndex = 10;
            lblType.Text = "EXPENSE TYPE";
            // 
            // DGTTL
            // 
            DGTTL.AllowUserToAddRows = false;
            DGTTL.AllowUserToDeleteRows = false;
            DGTTL.BackgroundColor = SystemColors.InactiveCaption;
            DGTTL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGTTL.Location = new Point(275, 95);
            DGTTL.Name = "DGTTL";
            DGTTL.ReadOnly = true;
            DGTTL.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGTTL.ScrollBars = ScrollBars.Vertical;
            DGTTL.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGTTL.Size = new Size(921, 243);
            DGTTL.TabIndex = 7;
            DGTTL.CellContentClick += DGTTL_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.AppStarting;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(24, 95);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(116, 27);
            button2.TabIndex = 5;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Rounded MT Bold", 23F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(15, 20);
            label2.Name = "label2";
            label2.Size = new Size(226, 38);
            label2.TabIndex = 3;
            label2.Text = "PHONE LINK";
            // 
            // Total
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1366, 749);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Total";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Total";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            EDITPANEL.ResumeLayout(false);
            EDITPANEL.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGTTL).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView DGTTL;
        private Button button2;
        private Panel EDITPANEL;
        private Button AddBtn;
        private TextBox textBox1;
        private TextBox txtET;
        private Label lblAmt;
        private Label label1;
        private Label lblType;
        private Label label3;
        private Label label4;
        private Button button3;
        private Label label5;
        private Label label6;
        private TextBox textBox2;
        private Button button1;
        private Label label7;
        private Label lblTC;
        private Label label8;
    }
}