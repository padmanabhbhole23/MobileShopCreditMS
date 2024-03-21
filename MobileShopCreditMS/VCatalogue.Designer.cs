namespace MobileShopCreditMS
{
    partial class VCatalogue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VCatalogue));
            panel2 = new Panel();
            label2 = new Label();
            button2 = new Button();
            panel1 = new Panel();
            dgv1 = new DataGridView();
            label3 = new Label();
            button1 = new Button();
            label1 = new Label();
            lblTSQ = new Label();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.AutoSize = true;
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Location = new Point(3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(234, 737);
            panel2.TabIndex = 4;
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
            button2.Location = new Point(9, 106);
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
            panel1.Controls.Add(lblTSQ);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dgv1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button1);
            panel1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(241, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 737);
            panel1.TabIndex = 5;
            // 
            // dgv1
            // 
            dgv1.AllowUserToDeleteRows = false;
            dgv1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv1.BackgroundColor = SystemColors.Control;
            dgv1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv1.Location = new Point(51, 140);
            dgv1.Name = "dgv1";
            dgv1.ReadOnly = true;
            dgv1.Size = new Size(1027, 422);
            dgv1.TabIndex = 24;
            dgv1.CellContentClick += dgv1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(26, 23);
            label3.Name = "label3";
            label3.Size = new Size(279, 34);
            label3.TabIndex = 23;
            label3.Text = "VIEW CATALOGUE";
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 20.25F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(652, 619);
            label1.Name = "label1";
            label1.Size = new Size(296, 33);
            label1.TabIndex = 25;
            label1.Text = "TOTAL AVAILABLE ITEMS :";
            label1.Click += label1_Click;
            // 
            // lblTSQ
            // 
            lblTSQ.AutoSize = true;
            lblTSQ.Font = new Font("Calibri", 20.25F, FontStyle.Bold);
            lblTSQ.ForeColor = Color.Green;
            lblTSQ.Location = new Point(989, 619);
            lblTSQ.Name = "lblTSQ";
            lblTSQ.Size = new Size(29, 33);
            lblTSQ.TabIndex = 26;
            lblTSQ.Text = "0";
            // 
            // VCatalogue
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1366, 749);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VCatalogue";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VCatalogue";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private Button button2;
        private Panel panel1;
        private Label label3;
        private Button button1;
        private DataGridView dgv1;
        private Label lblTSQ;
        private Label label1;
    }
}