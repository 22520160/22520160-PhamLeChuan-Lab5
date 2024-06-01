namespace Lab05
{
    partial class SendMail
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
            labelTo = new Label();
            labelFrom = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            checkBoxHtml = new CheckBox();
            txtfrom = new TextBox();
            txtname = new TextBox();
            txtto = new TextBox();
            txtsubject = new TextBox();
            richTextBox1 = new RichTextBox();
            txtfile = new TextBox();
            label4 = new Label();
            buttonBrowse = new Button();
            buttonSend = new Button();
            SuspendLayout();
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.BackColor = Color.Transparent;
            labelTo.Location = new Point(12, 80);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(28, 20);
            labelTo.TabIndex = 3;
            labelTo.Text = "To:";
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.BackColor = Color.Transparent;
            labelFrom.Location = new Point(12, 11);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(46, 20);
            labelFrom.TabIndex = 2;
            labelFrom.Text = "From:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 5;
            label1.Text = "Subject:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(12, 46);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 4;
            label2.Text = "Name: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(12, 156);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 6;
            label3.Text = "Body";
            // 
            // checkBoxHtml
            // 
            checkBoxHtml.AutoSize = true;
            checkBoxHtml.BackColor = Color.Transparent;
            checkBoxHtml.Location = new Point(93, 155);
            checkBoxHtml.Margin = new Padding(3, 4, 3, 4);
            checkBoxHtml.Name = "checkBoxHtml";
            checkBoxHtml.Size = new Size(70, 24);
            checkBoxHtml.TabIndex = 7;
            checkBoxHtml.Text = "HTML";
            checkBoxHtml.UseVisualStyleBackColor = false;
            // 
            // txtfrom
            // 
            txtfrom.BackColor = Color.White;
            txtfrom.Location = new Point(93, 8);
            txtfrom.Margin = new Padding(3, 4, 3, 4);
            txtfrom.Name = "txtfrom";
            txtfrom.ReadOnly = true;
            txtfrom.Size = new Size(513, 27);
            txtfrom.TabIndex = 8;
            // 
            // txtname
            // 
            txtname.BackColor = Color.White;
            txtname.Location = new Point(93, 42);
            txtname.Margin = new Padding(3, 4, 3, 4);
            txtname.Name = "txtname";
            txtname.Size = new Size(513, 27);
            txtname.TabIndex = 9;
            // 
            // txtto
            // 
            txtto.BackColor = Color.White;
            txtto.Location = new Point(93, 76);
            txtto.Margin = new Padding(3, 4, 3, 4);
            txtto.Name = "txtto";
            txtto.Size = new Size(513, 27);
            txtto.TabIndex = 10;
            // 
            // txtsubject
            // 
            txtsubject.BackColor = Color.White;
            txtsubject.Location = new Point(93, 112);
            txtsubject.Margin = new Padding(3, 4, 3, 4);
            txtsubject.Name = "txtsubject";
            txtsubject.Size = new Size(513, 27);
            txtsubject.TabIndex = 11;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.White;
            richTextBox1.Location = new Point(93, 208);
            richTextBox1.Margin = new Padding(3, 4, 3, 4);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(512, 314);
            richTextBox1.TabIndex = 12;
            richTextBox1.Text = "";
            // 
            // txtfile
            // 
            txtfile.BackColor = Color.White;
            txtfile.Location = new Point(104, 560);
            txtfile.Margin = new Padding(3, 4, 3, 4);
            txtfile.Name = "txtfile";
            txtfile.Size = new Size(420, 27);
            txtfile.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 563);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 13;
            label4.Text = "Attachment";
            // 
            // buttonBrowse
            // 
            buttonBrowse.BackColor = Color.Silver;
            buttonBrowse.Location = new Point(532, 554);
            buttonBrowse.Margin = new Padding(3, 4, 3, 4);
            buttonBrowse.Name = "buttonBrowse";
            buttonBrowse.Size = new Size(75, 29);
            buttonBrowse.TabIndex = 15;
            buttonBrowse.Text = "Browse...";
            buttonBrowse.UseVisualStyleBackColor = false;
            buttonBrowse.Click += buttonBrowse_Click;
            // 
            // buttonSend
            // 
            buttonSend.BackColor = Color.Silver;
            buttonSend.Location = new Point(532, 609);
            buttonSend.Margin = new Padding(3, 4, 3, 4);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(75, 29);
            buttonSend.TabIndex = 16;
            buttonSend.Text = "Send";
            buttonSend.UseVisualStyleBackColor = false;
            buttonSend.Click += buttonSend_Click;
            // 
            // SendMail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(618, 649);
            Controls.Add(buttonSend);
            Controls.Add(buttonBrowse);
            Controls.Add(txtfile);
            Controls.Add(label4);
            Controls.Add(richTextBox1);
            Controls.Add(txtsubject);
            Controls.Add(txtto);
            Controls.Add(txtname);
            Controls.Add(txtfrom);
            Controls.Add(checkBoxHtml);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(labelTo);
            Controls.Add(labelFrom);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SendMail";
            Text = "SendMail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxHtml;
        private System.Windows.Forms.TextBox txtfrom;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.TextBox txtsubject;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox txtfile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button buttonSend;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion
    }
}