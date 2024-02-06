namespace MobileShopCreditMS
{
    partial class ADash
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(186, 87);
            button1.Name = "button1";
            button1.Size = new Size(167, 75);
            button1.TabIndex = 0;
            button1.Text = "VIEW CUSTOMER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(535, 87);
            button2.Name = "button2";
            button2.Size = new Size(167, 75);
            button2.TabIndex = 1;
            button2.Text = "VIEW CATALOGUE";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(186, 207);
            button3.Name = "button3";
            button3.Size = new Size(167, 75);
            button3.TabIndex = 2;
            button3.Text = "MANAGE INVENTORY";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(535, 207);
            button4.Name = "button4";
            button4.Size = new Size(167, 75);
            button4.TabIndex = 3;
            button4.Text = "MANAGE REPORT";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(186, 337);
            button5.Name = "button5";
            button5.Size = new Size(167, 75);
            button5.TabIndex = 4;
            button5.Text = "TOTAL CREDIT";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(535, 337);
            button6.Name = "button6";
            button6.Size = new Size(167, 75);
            button6.TabIndex = 5;
            button6.Text = "CHANGE PASSWORD";
            button6.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Arial Rounded MT Bold", 21.75F, FontStyle.Bold);
            label2.ForeColor = Color.Maroon;
            label2.Location = new Point(26, 23);
            label2.Name = "label2";
            label2.Size = new Size(209, 35);
            label2.TabIndex = 7;
            label2.Text = "PHONE LINK";
            // 
            // ADash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.Bisque;
            ClientSize = new Size(857, 478);
            Controls.Add(label2);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ADash";
            Text = "Admin DashBoard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Label label2;
    }
}