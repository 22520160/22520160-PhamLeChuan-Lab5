namespace Lab05
{
    partial class ReadMail
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
            labelFrom = new Label();
            labelTo = new Label();
            labelTitle = new Label();
            webBrowser1 = new WebBrowser();
            labelToMail = new Label();
            labelFromName = new Label();
            SuspendLayout();
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.BackColor = Color.Transparent;
            labelFrom.ForeColor = Color.Black;
            labelFrom.Location = new Point(12, 22);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(46, 20);
            labelFrom.TabIndex = 0;
            labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.BackColor = Color.Transparent;
            labelTo.ForeColor = Color.Black;
            labelTo.Location = new Point(12, 61);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(28, 20);
            labelTo.TabIndex = 1;
            labelTo.Text = "To:";
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(12, 96);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(72, 25);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "TITLE";
            // 
            // webBrowser1
            // 
            webBrowser1.Location = new Point(12, 158);
            webBrowser1.Margin = new Padding(3, 4, 3, 4);
            webBrowser1.MinimumSize = new Size(20, 25);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new Size(591, 430);
            webBrowser1.TabIndex = 3;
            // 
            // labelToMail
            // 
            labelToMail.AutoSize = true;
            labelToMail.BackColor = Color.Transparent;
            labelToMail.ForeColor = Color.Black;
            labelToMail.Location = new Point(76, 61);
            labelToMail.Name = "labelToMail";
            labelToMail.Size = new Size(54, 20);
            labelToMail.TabIndex = 5;
            labelToMail.Text = "MailTo";
            // 
            // labelFromName
            // 
            labelFromName.AutoSize = true;
            labelFromName.BackColor = Color.Transparent;
            labelFromName.ForeColor = Color.Black;
            labelFromName.Location = new Point(76, 22);
            labelFromName.Name = "labelFromName";
            labelFromName.Size = new Size(38, 20);
            labelFromName.TabIndex = 4;
            labelFromName.Text = "Mail";
            // 
            // ReadMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 598);
            Controls.Add(labelToMail);
            Controls.Add(labelFromName);
            Controls.Add(webBrowser1);
            Controls.Add(labelTitle);
            Controls.Add(labelTo);
            Controls.Add(labelFrom);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReadMail";
            
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label labelToMail;
        private System.Windows.Forms.Label labelFromName;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion
    }
}