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
            DGTTL = new DataGridView();
            button2 = new Button();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGTTL).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(DGTTL);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1357, 742);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // DGTTL
            // 
            DGTTL.AllowUserToAddRows = false;
            DGTTL.AllowUserToDeleteRows = false;
            DGTTL.BackgroundColor = SystemColors.InactiveCaption;
            DGTTL.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGTTL.Location = new Point(301, 72);
            DGTTL.Name = "DGTTL";
            DGTTL.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            DGTTL.ScrollBars = ScrollBars.Vertical;
            DGTTL.Size = new Size(921, 279);
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
            ((System.ComponentModel.ISupportInitialize)DGTTL).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private DataGridView DGTTL;
        private Button button2;
    }
}