namespace Lab05
{
    partial class Bai02
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
            labelEmail = new Label();
            labelPass = new Label();
            textBoxEmail = new TextBox();
            textBoxPass = new TextBox();
            labelTotal = new Label();
            labelTotal_2 = new Label();
            labelRecent = new Label();
            labelRecent_2 = new Label();
            listViewMess = new ListView();
            buttonIMAP = new Button();
            buttonPop3 = new Button();
            SuspendLayout();
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(51, 40);
            labelEmail.Margin = new Padding(2, 0, 2, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(49, 20);
            labelEmail.TabIndex = 0;
            labelEmail.Text = "Email:";
            // 
            // labelPass
            // 
            labelPass.AutoSize = true;
            labelPass.Location = new Point(51, 90);
            labelPass.Margin = new Padding(2, 0, 2, 0);
            labelPass.Name = "labelPass";
            labelPass.Size = new Size(73, 20);
            labelPass.TabIndex = 1;
            labelPass.Text = "Password:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(142, 40);
            textBoxEmail.Margin = new Padding(2);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(365, 27);
            textBoxEmail.TabIndex = 2;
            // 
            // textBoxPass
            // 
            textBoxPass.Location = new Point(142, 90);
            textBoxPass.Margin = new Padding(2);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.PasswordChar = '*';
            textBoxPass.Size = new Size(365, 27);
            textBoxPass.TabIndex = 3;
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(51, 164);
            labelTotal.Margin = new Padding(2, 0, 2, 0);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(45, 20);
            labelTotal.TabIndex = 5;
            labelTotal.Text = "Total:";
            // 
            // labelTotal_2
            // 
            labelTotal_2.AutoSize = true;
            labelTotal_2.Location = new Point(128, 164);
            labelTotal_2.Margin = new Padding(2, 0, 2, 0);
            labelTotal_2.Name = "labelTotal_2";
            labelTotal_2.Size = new Size(0, 20);
            labelTotal_2.TabIndex = 6;
            // 
            // labelRecent
            // 
            labelRecent.AutoSize = true;
            labelRecent.Location = new Point(266, 164);
            labelRecent.Margin = new Padding(2, 0, 2, 0);
            labelRecent.Name = "labelRecent";
            labelRecent.Size = new Size(57, 20);
            labelRecent.TabIndex = 7;
            labelRecent.Text = "Recent:";
            // 
            // labelRecent_2
            // 
            labelRecent_2.AutoSize = true;
            labelRecent_2.Location = new Point(329, 164);
            labelRecent_2.Margin = new Padding(2, 0, 2, 0);
            labelRecent_2.Name = "labelRecent_2";
            labelRecent_2.Size = new Size(0, 20);
            labelRecent_2.TabIndex = 8;
            // 
            // listViewMess
            // 
            listViewMess.Location = new Point(11, 199);
            listViewMess.Margin = new Padding(2);
            listViewMess.Name = "listViewMess";
            listViewMess.Size = new Size(794, 289);
            listViewMess.TabIndex = 9;
            listViewMess.UseCompatibleStateImageBehavior = false;
            listViewMess.View = View.Details;
            // 
            // buttonIMAP
            // 
            buttonIMAP.Location = new Point(574, 61);
            buttonIMAP.Margin = new Padding(2);
            buttonIMAP.Name = "buttonIMAP";
            buttonIMAP.Size = new Size(73, 44);
            buttonIMAP.TabIndex = 10;
            buttonIMAP.Text = "IMAP";
            buttonIMAP.UseVisualStyleBackColor = true;
            buttonIMAP.Click += buttonIMAP_Click;
            // 
            // buttonPop3
            // 
            buttonPop3.Location = new Point(705, 61);
            buttonPop3.Margin = new Padding(2);
            buttonPop3.Name = "buttonPop3";
            buttonPop3.Size = new Size(70, 44);
            buttonPop3.TabIndex = 11;
            buttonPop3.Text = "Pop3";
            buttonPop3.UseVisualStyleBackColor = true;
            buttonPop3.Click += buttonPop3_Click;
            // 
            // Bai02
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(812, 499);
            Controls.Add(buttonPop3);
            Controls.Add(buttonIMAP);
            Controls.Add(listViewMess);
            Controls.Add(labelRecent_2);
            Controls.Add(labelRecent);
            Controls.Add(labelTotal_2);
            Controls.Add(labelTotal);
            Controls.Add(textBoxPass);
            Controls.Add(textBoxEmail);
            Controls.Add(labelPass);
            Controls.Add(labelEmail);
            Margin = new Padding(2);
            Name = "Bai02";
            Text = "Bai2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotal_2;
        private System.Windows.Forms.Label labelRecent;
        private System.Windows.Forms.Label labelRecent_2;
        private System.Windows.Forms.ListView listViewMess;
        private System.Windows.Forms.Button buttonIMAP;
        private System.Windows.Forms.Button buttonPop3;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion
    }
}