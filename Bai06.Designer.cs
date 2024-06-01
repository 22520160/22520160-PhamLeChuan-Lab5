namespace Lab05
{
    partial class Bai06
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
            groupBox1 = new GroupBox();
            buttonRefresh = new Button();
            buttonSendMail = new Button();
            txtmatkhau = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            buttonSignIn = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            groupBox2 = new GroupBox();
            txtsmtpport = new TextBox();
            txtsmtp = new TextBox();
            txtimapport = new TextBox();
            txtimap = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            listView1 = new ListView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(buttonRefresh);
            groupBox1.Controls.Add(buttonSendMail);
            groupBox1.Controls.Add(txtmatkhau);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(buttonSignIn);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(12, 15);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(353, 145);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập";
            // 
            // buttonRefresh
            // 
            buttonRefresh.BackColor = Color.LightGray;
            buttonRefresh.ForeColor = Color.Black;
            buttonRefresh.Location = new Point(98, 102);
            buttonRefresh.Margin = new Padding(3, 4, 3, 4);
            buttonRefresh.Name = "buttonRefresh";
            buttonRefresh.Size = new Size(97, 35);
            buttonRefresh.TabIndex = 8;
            buttonRefresh.Text = "Refresh";
            buttonRefresh.UseVisualStyleBackColor = false;
            buttonRefresh.Click += buttonRefresh_Click;
            // 
            // buttonSendMail
            // 
            buttonSendMail.BackColor = Color.LightGray;
            buttonSendMail.ForeColor = Color.Black;
            buttonSendMail.Location = new Point(9, 102);
            buttonSendMail.Margin = new Padding(3, 4, 3, 4);
            buttonSendMail.Name = "buttonSendMail";
            buttonSendMail.Size = new Size(83, 35);
            buttonSendMail.TabIndex = 7;
            buttonSendMail.Text = "Gửi mail";
            buttonSendMail.UseVisualStyleBackColor = false;
            buttonSendMail.Click += buttonSendMail_Click;
            // 
            // txtmatkhau
            // 
            txtmatkhau.BackColor = Color.White;
            txtmatkhau.Location = new Point(96, 54);
            txtmatkhau.Margin = new Padding(3, 4, 3, 4);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.PasswordChar = '*';
            txtmatkhau.Size = new Size(251, 27);
            txtmatkhau.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(96, 15);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 27);
            txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 54);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 3;
            label1.Text = "Tài khoản";
            // 
            // buttonSignIn
            // 
            buttonSignIn.BackColor = Color.LightGray;
            buttonSignIn.ForeColor = Color.Black;
            buttonSignIn.Location = new Point(201, 102);
            buttonSignIn.Margin = new Padding(3, 4, 3, 4);
            buttonSignIn.Name = "buttonSignIn";
            buttonSignIn.Size = new Size(146, 35);
            buttonSignIn.TabIndex = 2;
            buttonSignIn.Text = "Đăng nhập";
            buttonSignIn.UseVisualStyleBackColor = false;
            buttonSignIn.Click += buttonSignIn_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(txtsmtpport);
            groupBox2.Controls.Add(txtsmtp);
            groupBox2.Controls.Add(txtimapport);
            groupBox2.Controls.Add(txtimap);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.ForeColor = Color.Black;
            groupBox2.Location = new Point(371, 15);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(525, 145);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cài đặt";
            // 
            // txtsmtpport
            // 
            txtsmtpport.BackColor = Color.White;
            txtsmtpport.Location = new Point(322, 54);
            txtsmtpport.Margin = new Padding(3, 4, 3, 4);
            txtsmtpport.Name = "txtsmtpport";
            txtsmtpport.Size = new Size(197, 27);
            txtsmtpport.TabIndex = 10;
            // 
            // txtsmtp
            // 
            txtsmtp.BackColor = Color.White;
            txtsmtp.Location = new Point(322, 15);
            txtsmtp.Margin = new Padding(3, 4, 3, 4);
            txtsmtp.Name = "txtsmtp";
            txtsmtp.Size = new Size(197, 27);
            txtsmtp.TabIndex = 9;
            // 
            // txtimapport
            // 
            txtimapport.BackColor = Color.White;
            txtimapport.Location = new Point(56, 54);
            txtimapport.Margin = new Padding(3, 4, 3, 4);
            txtimapport.Name = "txtimapport";
            txtimapport.Size = new Size(207, 27);
            txtimapport.TabIndex = 8;
            // 
            // txtimap
            // 
            txtimap.BackColor = Color.White;
            txtimap.Location = new Point(56, 15);
            txtimap.Margin = new Padding(3, 4, 3, 4);
            txtimap.Name = "txtimap";
            txtimap.Size = new Size(207, 27);
            txtimap.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(272, 54);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(35, 20);
            label5.TabIndex = 7;
            label5.Text = "Port";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(272, 22);
            label6.Name = "label6";
            label6.Size = new Size(46, 20);
            label6.TabIndex = 6;
            label6.Text = "SMTP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 54);
            label4.Name = "label4";
            label4.Size = new Size(35, 20);
            label4.TabIndex = 5;
            label4.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 22);
            label3.Name = "label3";
            label3.Size = new Size(44, 20);
            label3.TabIndex = 4;
            label3.Text = "IMAP";
            // 
            // listView1
            // 
            listView1.BackColor = Color.White;
            listView1.Location = new Point(12, 168);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(884, 488);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(908, 671);
            Controls.Add(listView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Bai06";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSignIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox txtmatkhau;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtsmtpport;
        private System.Windows.Forms.TextBox txtsmtp;
        private System.Windows.Forms.TextBox txtimapport;
        private System.Windows.Forms.TextBox txtimap;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonSendMail;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion
    }
}