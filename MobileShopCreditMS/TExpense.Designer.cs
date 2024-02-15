namespace MobileShopCreditMS
{
    partial class TExpense
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
            panel1 = new Panel();
            button3 = new Button();
            EditPanel = new Panel();
            monthCalendar1 = new MonthCalendar();
            txtDesc = new TextBox();
            txtAmt = new TextBox();
            txtET = new TextBox();
            lblDesc = new Label();
            lblAmt = new Label();
            lbldate = new Label();
            lblType = new Label();
            btnClr = new Button();
            btnAdd = new Button();
            DGExp = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            EditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGExp).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(EditPanel);
            panel1.Controls.Add(DGExp);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(5, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1357, 742);
            panel1.TabIndex = 1;
            // 
            // button3
            // 
            button3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button3.Location = new Point(226, 344);
            button3.Name = "button3";
            button3.Size = new Size(209, 43);
            button3.TabIndex = 8;
            button3.Text = "EDIT";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // EditPanel
            // 
            EditPanel.AutoScroll = true;
            EditPanel.Controls.Add(monthCalendar1);
            EditPanel.Controls.Add(txtDesc);
            EditPanel.Controls.Add(txtAmt);
            EditPanel.Controls.Add(txtET);
            EditPanel.Controls.Add(lblDesc);
            EditPanel.Controls.Add(lblAmt);
            EditPanel.Controls.Add(lbldate);
            EditPanel.Controls.Add(lblType);
            EditPanel.Controls.Add(btnClr);
            EditPanel.Controls.Add(btnAdd);
            EditPanel.Location = new Point(226, 393);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(851, 341);
            EditPanel.TabIndex = 7;
            EditPanel.Visible = false;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(210, 65);
            monthCalendar1.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 10;
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(210, 281);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(296, 45);
            txtDesc.TabIndex = 9;
            // 
            // txtAmt
            // 
            txtAmt.Location = new Point(210, 244);
            txtAmt.Name = "txtAmt";
            txtAmt.Size = new Size(164, 23);
            txtAmt.TabIndex = 8;
            // 
            // txtET
            // 
            txtET.Location = new Point(210, 22);
            txtET.Name = "txtET";
            txtET.Size = new Size(223, 23);
            txtET.TabIndex = 6;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.ImageAlign = ContentAlignment.TopLeft;
            lblDesc.Location = new Point(56, 292);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(129, 15);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "EXPENSE DESCRIPTION";
            // 
            // lblAmt
            // 
            lblAmt.AutoSize = true;
            lblAmt.Location = new Point(77, 247);
            lblAmt.Name = "lblAmt";
            lblAmt.Size = new Size(108, 15);
            lblAmt.TabIndex = 4;
            lblAmt.Text = "EXPENSE AMOUNT";
            // 
            // lbldate
            // 
            lbldate.AutoSize = true;
            lbldate.Location = new Point(101, 82);
            lbldate.Name = "lbldate";
            lbldate.Size = new Size(84, 15);
            lbldate.TabIndex = 3;
            lbldate.Text = "EXPENSE DATE";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(101, 25);
            lblType.Name = "lblType";
            lblType.Size = new Size(83, 15);
            lblType.TabIndex = 2;
            lblType.Text = "EXPENSE TYPE";
            // 
            // btnClr
            // 
            btnClr.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnClr.Location = new Point(699, 281);
            btnClr.Name = "btnClr";
            btnClr.Size = new Size(116, 35);
            btnClr.TabIndex = 1;
            btnClr.Text = "CLEAR";
            btnClr.UseVisualStyleBackColor = true;
            btnClr.Click += btnClr_Click;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Calibri", 12F, FontStyle.Bold);
            btnAdd.Location = new Point(564, 281);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(116, 35);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "UPDATE TABLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // DGExp
            // 
            DGExp.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGExp.Location = new Point(226, 122);
            DGExp.Name = "DGExp";
            DGExp.ReadOnly = true;
            DGExp.ScrollBars = ScrollBars.Vertical;
            DGExp.Size = new Size(851, 216);
            DGExp.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.AppStarting;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(15, 79);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(116, 27);
            button2.TabIndex = 5;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1222, 21);
            button1.Name = "button1";
            button1.Size = new Size(114, 37);
            button1.TabIndex = 4;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            // TExpense
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1366, 749);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TExpense";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TExpense";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            EditPanel.ResumeLayout(false);
            EditPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGExp).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button button1;
        private Button button2;
        private DataGridView DGExp;
        private Button button3;
        private Panel EditPanel;
        private Button btnAdd;
        private Button btnClr;
        private Label lbldate;
        private Label lblType;
        private Label lblDesc;
        private Label lblAmt;
        private MonthCalendar monthCalendar1;
        private TextBox txtDesc;
        private TextBox txtAmt;
        private TextBox txtET;
    }
}