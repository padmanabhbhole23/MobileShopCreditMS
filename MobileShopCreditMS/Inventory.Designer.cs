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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            panel1 = new Panel();
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
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)products).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Rounded MT Bold", 23F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(321, 9);
            label2.Name = "label2";
            label2.Size = new Size(170, 38);
            label2.TabIndex = 3;
            label2.Text = "Inventory";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 75);
            label1.Name = "label1";
            label1.Size = new Size(96, 17);
            label1.TabIndex = 4;
            label1.Text = "Product Name";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(289, 75);
            label3.Name = "label3";
            label3.Size = new Size(131, 17);
            label3.TabIndex = 5;
            label3.Text = "Product Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(563, 75);
            label4.Name = "label4";
            label4.Size = new Size(90, 17);
            label4.TabIndex = 6;
            label4.Text = "Product Price";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(20, 145);
            label5.Name = "label5";
            label5.Size = new Size(116, 17);
            label5.TabIndex = 7;
            label5.Text = "Product Category";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(289, 145);
            label6.Name = "label6";
            label6.Size = new Size(96, 17);
            label6.TabIndex = 8;
            label6.Text = "Product Brand";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(563, 145);
            label7.Name = "label7";
            label7.Size = new Size(119, 17);
            label7.TabIndex = 9;
            label7.Text = "Product Image url";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(22, 221);
            label8.Name = "label8";
            label8.Size = new Size(114, 17);
            label8.TabIndex = 10;
            label8.Text = "Product Quantity";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(289, 221);
            label9.Name = "label9";
            label9.Size = new Size(98, 17);
            label9.TabIndex = 11;
            label9.Text = "Downpayment";
            // 
            // panel1
            // 
            panel1.BackColor = Color.OrangeRed;
            panel1.Location = new Point(1, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(814, 10);
            panel1.TabIndex = 12;
            // 
            // PName
            // 
            PName.Location = new Point(124, 69);
            PName.Name = "PName";
            PName.Size = new Size(100, 23);
            PName.TabIndex = 13;
            // 
            // PDesc
            // 
            PDesc.Location = new Point(426, 69);
            PDesc.Name = "PDesc";
            PDesc.Size = new Size(100, 23);
            PDesc.TabIndex = 14;
            // 
            // PPrice
            // 
            PPrice.Location = new Point(659, 69);
            PPrice.Name = "PPrice";
            PPrice.Size = new Size(100, 23);
            PPrice.TabIndex = 15;
            // 
            // PCat
            // 
            PCat.FormattingEnabled = true;
            PCat.Items.AddRange(new object[] { "MOBILE PHONE", "ACCESSORIES", "OTHER" });
            PCat.Location = new Point(142, 139);
            PCat.Name = "PCat";
            PCat.Size = new Size(121, 23);
            PCat.TabIndex = 16;
            // 
            // PBrand
            // 
            PBrand.Location = new Point(391, 139);
            PBrand.Name = "PBrand";
            PBrand.Size = new Size(100, 23);
            PBrand.TabIndex = 17;
            // 
            // PImage
            // 
            PImage.Location = new Point(688, 139);
            PImage.Name = "PImage";
            PImage.Size = new Size(100, 23);
            PImage.TabIndex = 18;
            // 
            // PQty
            // 
            PQty.Location = new Point(142, 215);
            PQty.Name = "PQty";
            PQty.Size = new Size(100, 23);
            PQty.TabIndex = 19;
            // 
            // PDp
            // 
            PDp.Location = new Point(393, 215);
            PDp.Name = "PDp";
            PDp.Size = new Size(100, 23);
            PDp.TabIndex = 20;
            // 
            // AddBtn
            // 
            AddBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.Location = new Point(549, 218);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(75, 23);
            AddBtn.TabIndex = 21;
            AddBtn.Text = "ADD";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += button1_Click;
            // 
            // products
            // 
            products.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            products.Location = new Point(5, 275);
            products.Name = "products";
            products.Size = new Size(798, 168);
            products.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(784, 9);
            label10.Name = "label10";
            label10.Size = new Size(19, 20);
            label10.TabIndex = 23;
            label10.Text = "X";
            label10.Click += label10_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(815, 455);
            Controls.Add(label10);
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
            Controls.Add(panel1);
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
            Name = "Inventory";
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
        private Panel panel1;
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
        private Label label10;
    }
}