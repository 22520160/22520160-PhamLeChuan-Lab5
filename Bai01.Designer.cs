namespace Lab05
{
    partial class Bai01
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
            buttonSend = new Button();
            labelFrom = new Label();
            labelTo = new Label();
            textBoxFrom = new TextBox();
            textBoxTo = new TextBox();
            labelSubject = new Label();
            labelBody = new Label();
            textBoxSubject = new TextBox();
            richTextBoxBody = new RichTextBox();
            SuspendLayout();
            // 
            // buttonSend
            // 
            buttonSend.Location = new Point(9, 45);
            buttonSend.Margin = new Padding(2);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new Size(93, 55);
            buttonSend.TabIndex = 0;
            buttonSend.Text = "SEND";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += buttonSend_Click;
            // 
            // labelFrom
            // 
            labelFrom.AutoSize = true;
            labelFrom.Location = new Point(119, 34);
            labelFrom.Margin = new Padding(2, 0, 2, 0);
            labelFrom.Name = "labelFrom";
            labelFrom.Size = new Size(50, 20);
            labelFrom.TabIndex = 1;
            labelFrom.Text = "From: ";
            // 
            // labelTo
            // 
            labelTo.AutoSize = true;
            labelTo.Location = new Point(119, 79);
            labelTo.Margin = new Padding(2, 0, 2, 0);
            labelTo.Name = "labelTo";
            labelTo.Size = new Size(28, 20);
            labelTo.TabIndex = 2;
            labelTo.Text = "To:";
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(173, 31);
            textBoxFrom.Margin = new Padding(2);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(292, 27);
            textBoxFrom.TabIndex = 3;
            // 
            // textBoxTo
            // 
            textBoxTo.Location = new Point(173, 76);
            textBoxTo.Margin = new Padding(2);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(292, 27);
            textBoxTo.TabIndex = 4;
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Location = new Point(31, 149);
            labelSubject.Margin = new Padding(2, 0, 2, 0);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(61, 20);
            labelSubject.TabIndex = 5;
            labelSubject.Text = "Subject:";
            // 
            // labelBody
            // 
            labelBody.AutoSize = true;
            labelBody.Location = new Point(31, 224);
            labelBody.Margin = new Padding(2, 0, 2, 0);
            labelBody.Name = "labelBody";
            labelBody.Size = new Size(46, 20);
            labelBody.TabIndex = 6;
            labelBody.Text = "Body:";
            // 
            // textBoxSubject
            // 
            textBoxSubject.Location = new Point(119, 149);
            textBoxSubject.Margin = new Padding(2);
            textBoxSubject.Name = "textBoxSubject";
            textBoxSubject.Size = new Size(656, 27);
            textBoxSubject.TabIndex = 7;
            // 
            // richTextBoxBody
            // 
            richTextBoxBody.Location = new Point(119, 221);
            richTextBoxBody.Margin = new Padding(2);
            richTextBoxBody.Name = "richTextBoxBody";
            richTextBoxBody.Size = new Size(656, 240);
            richTextBoxBody.TabIndex = 8;
            richTextBoxBody.Text = "";
            // 
            // Bai01
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 472);
            Controls.Add(richTextBoxBody);
            Controls.Add(textBoxSubject);
            Controls.Add(labelBody);
            Controls.Add(labelSubject);
            Controls.Add(textBoxTo);
            Controls.Add(textBoxFrom);
            Controls.Add(labelTo);
            Controls.Add(labelFrom);
            Controls.Add(buttonSend);
            Margin = new Padding(2);
            Name = "Bai01";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.RichTextBox richTextBoxBody;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
       

        #endregion
    }
}