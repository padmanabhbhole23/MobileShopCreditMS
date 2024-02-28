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
            label3 = new Label();
            AddBtn = new Button();
            EDITPANEL = new Panel();
            button1 = new Button();
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
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(275, 23);
            label3.Name = "label3";
            label3.Size = new Size(227, 34);
            label3.TabIndex = 24;
            label3.Text = "TOTAL CREDIT";
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(275, 323);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(210, 44);
            AddBtn.TabIndex = 22;
            AddBtn.Text = "UPDATE";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // EDITPANEL
            // 
            EDITPANEL.Controls.Add(button1);
            EDITPANEL.Controls.Add(textBox1);
            EDITPANEL.Controls.Add(txtET);
            EDITPANEL.Controls.Add(lblAmt);
            EDITPANEL.Controls.Add(label1);
            EDITPANEL.Controls.Add(lblType);
            EDITPANEL.Location = new Point(275, 383);
            EDITPANEL.Name = "EDITPANEL";
            EDITPANEL.Size = new Size(693, 334);
            EDITPANEL.TabIndex = 8;
            EDITPANEL.Visible = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(221, 242);
            button1.Name = "button1";
            button1.Size = new Size(185, 53);
            button1.TabIndex = 23;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(223, 23);
            textBox1.TabIndex = 13;
            // 
            // txtET
            // 
            txtET.Location = new Point(183, 116);
            txtET.Name = "txtET";
            txtET.Size = new Size(223, 23);
            txtET.TabIndex = 13;
            // 
            // lblAmt
            // 
            lblAmt.AutoSize = true;
            lblAmt.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblAmt.Location = new Point(26, 71);
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
            label1.Location = new Point(26, 15);
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
            DGTTL.Location = new Point(275, 62);
            DGTTL.Name = "DGTTL";
            DGTTL.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGTTL.ScrollBars = ScrollBars.Vertical;
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
        private Button button1;
        private Label label3;
    }
}