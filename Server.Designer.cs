namespace Lab05
{
    partial class Server
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
            txtmatkhau = new TextBox();
            txttaikhoan = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtmatkhau
            // 
            txtmatkhau.BackColor = Color.White;
            txtmatkhau.Location = new Point(87, 71);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.PasswordChar = '*';
            txtmatkhau.Size = new Size(288, 27);
            txtmatkhau.TabIndex = 10;
            // 
            // txttaikhoan
            // 
            txttaikhoan.BackColor = Color.White;
            txttaikhoan.Location = new Point(88, 11);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(287, 27);
            txttaikhoan.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(11, 74);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 8;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 12);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 7;
            label1.Text = "Tài khoản";
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(290, 126);
            button1.Name = "button1";
            button1.Size = new Size(85, 41);
            button1.TabIndex = 6;
            button1.Text = "Listen";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 179);
            Controls.Add(txtmatkhau);
            Controls.Add(txttaikhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txttaikhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        
        #endregion
    }
}