namespace MobileShopCreditMS
{
    partial class Inventory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            PName = new TextBox();
            PDesc = new TextBox();
            PPrice = new TextBox();
            PCat = new ComboBox();
            PBrand = new TextBox();
            PImage = new TextBox();
            PQty = new TextBox();
            PDp = new TextBox();
            AddBtn = new Button();
            products = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)products).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Rounded MT Bold", 20F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(250, 24);
            label2.Name = "label2";
            label2.Size = new Size(320, 34);
            label2.TabIndex = 3;
            label2.Text = "MANAGE INVENTORY";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(116, 197);
            label1.Name = "label1";
            label1.Size = new Size(108, 19);
            label1.TabIndex = 4;
            label1.Text = "Product Name";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.Location = new Point(110, 309);
            label3.Name = "label3";
            label3.Size = new Size(145, 19);
            label3.TabIndex = 5;
            label3.Text = "Product Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label4.Location = new Point(116, 411);
            label4.Name = "label4";
            label4.Size = new Size(102, 19);
            label4.TabIndex = 6;
            label4.Text = "Product Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label5.Location = new Point(116, 106);
            label5.Name = "label5";
            label5.Size = new Size(129, 19);
            label5.TabIndex = 7;
            label5.Text = "Product Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label6.Location = new Point(116, 147);
            label6.Name = "label6";
            label6.Size = new Size(109, 19);
            label6.TabIndex = 8;
            label6.Text = "Product Brand";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label7.Location = new Point(105, 465);
            label7.Name = "label7";
            label7.Size = new Size(132, 19);
            label7.TabIndex = 9;
            label7.Text = "Product Image url";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label8.Location = new Point(110, 249);
            label8.Name = "label8";
            label8.Size = new Size(128, 19);
            label8.TabIndex = 10;
            label8.Text = "Product Quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(116, 535);
            label9.Name = "label9";
            label9.Size = new Size(98, 17);
            label9.TabIndex = 11;
            label9.Text = "Downpayment";
            // 
            // PName
            // 
            PName.Location = new Point(283, 191);
            PName.Name = "PName";
            PName.Size = new Size(201, 23);
            PName.TabIndex = 13;
            // 
            // PDesc
            // 
            PDesc.Location = new Point(283, 303);
            PDesc.Multiline = true;
            PDesc.Name = "PDesc";
            PDesc.Size = new Size(210, 70);
            PDesc.TabIndex = 14;
            // 
            // PPrice
            // 
            PPrice.Location = new Point(283, 405);
            PPrice.Name = "PPrice";
            PPrice.Size = new Size(100, 23);
            PPrice.TabIndex = 15;
            // 
            // PCat
            // 
            PCat.FormattingEnabled = true;
            PCat.Items.AddRange(new object[] { "MOBILE PHONE", "ACCESSORIES", "OTHER" });
            PCat.Location = new Point(283, 105);
            PCat.Name = "PCat";
            PCat.Size = new Size(121, 23);
            PCat.TabIndex = 16;
            // 
            // PBrand
            // 
            PBrand.Location = new Point(283, 141);
            PBrand.Name = "PBrand";
            PBrand.Size = new Size(201, 23);
            PBrand.TabIndex = 17;
            // 
            // PImage
            // 
            PImage.Location = new Point(283, 465);
            PImage.Name = "PImage";
            PImage.Size = new Size(210, 23);
            PImage.TabIndex = 18;
            // 
            // PQty
            // 
            PQty.Location = new Point(283, 243);
            PQty.Name = "PQty";
            PQty.Size = new Size(100, 23);
            PQty.TabIndex = 19;
            // 
            // PDp
            // 
            PDp.Location = new Point(283, 529);
            PDp.Name = "PDp";
            PDp.Size = new Size(100, 23);
            PDp.TabIndex = 20;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(151, 624);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(290, 55);
            AddBtn.TabIndex = 21;
            AddBtn.Text = "ADD PRODUCT";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += button1_Click;
            // 
            // products
            // 
            products.BackgroundColor = SystemColors.InactiveCaption;
            products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            products.Location = new Point(548, 89);
            products.Name = "products";
            products.Size = new Size(787, 590);
            products.TabIndex = 22;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(1240, 19);
            button1.Name = "button1";
            button1.Size = new Size(114, 37);
            button1.TabIndex = 25;
            button1.Text = "EXIT";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.Cursor = Cursors.AppStarting;
            button2.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 76);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(116, 27);
            button2.TabIndex = 24;
            button2.Text = "BACK";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BorderStyle = BorderStyle.FixedSingle;
            label10.Font = new Font("Arial Rounded MT Bold", 23F, FontStyle.Bold);
            label10.ForeColor = Color.Maroon;
            label10.Location = new Point(12, 24);
            label10.Name = "label10";
            label10.Size = new Size(226, 38);
            label10.TabIndex = 26;
            label10.Text = "PHONE LINK";
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1366, 749);
            Controls.Add(label10);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(products);
            Controls.Add(AddBtn);
            Controls.Add(PDp);
            Controls.Add(PQty);
            Controls.Add(PImage);
            Controls.Add(PBrand);
            Controls.Add(PCat);
            Controls.Add(PPrice);
            Controls.Add(PDesc);
            Controls.Add(PName);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)products).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox PName;
        private TextBox PDesc;
        private TextBox PPrice;
        private ComboBox PCat;
        private TextBox PBrand;
        private TextBox PImage;
        private TextBox PQty;
        private TextBox PDp;
        private Button AddBtn;
        private DataGridView products;
        private Button button1;
        private Button button2;
        private Label label10;
    }
}