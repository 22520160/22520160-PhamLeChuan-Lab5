namespace Lab05
{
    partial class Bai04
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
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(160, 26);
            button2.Name = "button2";
            button2.Size = new Size(119, 52);
            button2.TabIndex = 5;
            button2.Text = "Open Client";
            button2.UseVisualStyleBackColor = false;
            button2.Click += this.button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(21, 26);
            button1.Name = "button1";
            button1.Size = new Size(119, 52);
            button1.TabIndex = 4;
            button1.Text = "Open Server";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(303, 105);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bai04";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion
    }
}