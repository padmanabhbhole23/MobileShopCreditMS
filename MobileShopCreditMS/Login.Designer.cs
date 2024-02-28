namespace MobileShopCreditMS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            textBox1 = new TextBox();
            textPass = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            lblUsr = new Label();
            lblPass = new Label();
            panel1 = new Panel();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(131, 183);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += Form1_KeyPress;
            // 
            // textPass
            // 
            textPass.BackColor = SystemColors.ControlLightLight;
            textPass.Cursor = Cursors.IBeam;
            textPass.Location = new Point(131, 279);
            textPass.Name = "textPass";
            textPass.PasswordChar = '*';
            textPass.Size = new Size(197, 23);
            textPass.TabIndex = 2;
            textPass.UseSystemPasswordChar = true;
            textPass.KeyPress += Form1_KeyPress;
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.PushButton;
            button1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            button1.Location = new Point(167, 343);
            button1.Name = "button1";
            button1.Size = new Size(117, 43);
            button1.TabIndex = 3;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user_Icon1;
            pictureBox1.Location = new Point(66, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 252);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(50, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lblUsr
            // 
            lblUsr.AutoSize = true;
            lblUsr.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblUsr.Location = new Point(131, 156);
            lblUsr.Name = "lblUsr";
            lblUsr.Size = new Size(135, 19);
            lblUsr.TabIndex = 10;
            lblUsr.Text = "ENTER USERNAME";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Calibri", 12F, FontStyle.Bold);
            lblPass.Location = new Point(131, 252);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(136, 19);
            lblPass.TabIndex = 11;
            lblPass.Text = "ENTER PASSWORD";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblPass);
            panel1.Controls.Add(lblUsr);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textPass);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(437, 475);
            panel1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label3.Location = new Point(334, 187);
            label3.Name = "label3";
            label3.Size = new Size(18, 19);
            label3.TabIndex = 14;
            label3.Text = "X";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Calibri", 12F, FontStyle.Bold);
            label1.Location = new Point(334, 279);
            label1.Name = "label1";
            label1.Size = new Size(18, 19);
            label1.TabIndex = 13;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Rounded MT Bold", 23F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(102, 61);
            label2.Name = "label2";
            label2.Size = new Size(226, 38);
            label2.TabIndex = 12;
            label2.Text = "PHONE LINK";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(437, 471);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            KeyPress += Form1_KeyPress;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textPass;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label lblUsr;
        private Label lblPass;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}