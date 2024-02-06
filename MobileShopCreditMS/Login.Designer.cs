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
            panel1 = new Panel();
            label2 = new Label();
            button1 = new Button();
            textPass = new TextBox();
            textBox1 = new TextBox();
            button2 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Bisque;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textPass);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(1, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(378, 381);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ImageKey = "(none)";
            label2.Location = new Point(58, 182);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // button1
            // 
            button1.AccessibleRole = AccessibleRole.PushButton;
            button1.Location = new Point(107, 234);
            button1.Name = "button1";
            button1.Size = new Size(92, 25);
            button1.TabIndex = 3;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textPass
            // 
            textPass.BackColor = SystemColors.ControlLightLight;
            textPass.Cursor = Cursors.IBeam;
            textPass.Location = new Point(107, 179);
            textPass.Name = "textPass";
            textPass.PlaceholderText = "ENTER PASSWORD";
            textPass.Size = new Size(197, 23);
            textPass.TabIndex = 2;
            textPass.UseSystemPasswordChar = true;
            textPass.TextChanged += textPass_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLightLight;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Location = new Point(107, 121);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "ENTER USERNAME";
            textBox1.Size = new Size(197, 23);
            textBox1.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(212, 234);
            button2.Name = "button2";
            button2.Size = new Size(92, 25);
            button2.TabIndex = 6;
            button2.Text = "CLEAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(381, 381);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private TextBox textPass;
        private TextBox textBox1;
        private Label label2;
        private Button button2;
    }
}