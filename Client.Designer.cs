namespace Lab05
{
    partial class Client
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
            txtto = new TextBox();
            label6 = new Label();
            button2 = new Button();
            label5 = new Label();
            label4 = new Label();
            nameTextBox = new TextBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            C5 = new CheckBox();
            C4 = new CheckBox();
            C3 = new CheckBox();
            C2 = new CheckBox();
            C1 = new CheckBox();
            B5 = new CheckBox();
            B4 = new CheckBox();
            B3 = new CheckBox();
            B2 = new CheckBox();
            B1 = new CheckBox();
            A5 = new CheckBox();
            A4 = new CheckBox();
            A3 = new CheckBox();
            A2 = new CheckBox();
            A1 = new CheckBox();
            SuspendLayout();
            // 
            // txtto
            // 
            txtto.BackColor = Color.White;
            txtto.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtto.Location = new Point(340, 555);
            txtto.Multiline = true;
            txtto.Name = "txtto";
            txtto.Size = new Size(295, 50);
            txtto.TabIndex = 176;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 15F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(19, 555);
            label6.Name = "label6";
            label6.Size = new Size(182, 29);
            label6.TabIndex = 175;
            label6.Text = "Email của bạn ";
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.Location = new Point(24, 129);
            button2.Name = "button2";
            button2.Size = new Size(146, 62);
            button2.TabIndex = 174;
            button2.Text = "Connect";
            button2.UseVisualStyleBackColor = false;
            button2.Click += buttonConnect_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(200, 23);
            label5.Name = "label5";
            label5.Size = new Size(274, 39);
            label5.TabIndex = 173;
            label5.Text = "Quản lí phòng vé";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(19, 502);
            label4.Name = "label4";
            label4.Size = new Size(295, 29);
            label4.TabIndex = 172;
            label4.Text = "Nhập vào họ tên của bạn";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.White;
            nameTextBox.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTextBox.Location = new Point(340, 488);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(295, 50);
            nameTextBox.TabIndex = 171;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.Location = new Point(24, 213);
            button1.Name = "button1";
            button1.Size = new Size(149, 59);
            button1.TabIndex = 170;
            button1.Text = "Đặt vé";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonSend_Click;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.White;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(478, 129);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(157, 28);
            comboBox2.TabIndex = 169;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(246, 129);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(157, 28);
            comboBox1.TabIndex = 168;
            comboBox1.Click += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = SystemColors.ActiveCaptionText;
            label3.Location = new Point(25, 427);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 167;
            label3.Text = "C";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(25, 361);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 166;
            label2.Text = "B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(25, 296);
            label1.Name = "label1";
            label1.Size = new Size(19, 20);
            label1.TabIndex = 165;
            label1.Text = "A";
            // 
            // C5
            // 
            C5.AutoSize = true;
            C5.BackColor = Color.Transparent;
            C5.ForeColor = SystemColors.ActiveCaptionText;
            C5.Location = new Point(588, 426);
            C5.Name = "C5";
            C5.Size = new Size(48, 24);
            C5.TabIndex = 164;
            C5.Text = "C5";
            C5.UseVisualStyleBackColor = false;
            // 
            // C4
            // 
            C4.AutoSize = true;
            C4.BackColor = Color.Transparent;
            C4.ForeColor = SystemColors.ActiveCaptionText;
            C4.Location = new Point(469, 426);
            C4.Name = "C4";
            C4.Size = new Size(48, 24);
            C4.TabIndex = 163;
            C4.Text = "C4";
            C4.UseVisualStyleBackColor = false;
            // 
            // C3
            // 
            C3.AutoSize = true;
            C3.BackColor = Color.Transparent;
            C3.ForeColor = SystemColors.ActiveCaptionText;
            C3.Location = new Point(354, 426);
            C3.Name = "C3";
            C3.Size = new Size(48, 24);
            C3.TabIndex = 162;
            C3.Text = "C3";
            C3.UseVisualStyleBackColor = false;
            // 
            // C2
            // 
            C2.AutoSize = true;
            C2.BackColor = Color.Transparent;
            C2.ForeColor = SystemColors.ActiveCaptionText;
            C2.Location = new Point(228, 426);
            C2.Name = "C2";
            C2.Size = new Size(48, 24);
            C2.TabIndex = 161;
            C2.Text = "C2";
            C2.UseVisualStyleBackColor = false;
            // 
            // C1
            // 
            C1.AutoSize = true;
            C1.BackColor = Color.Transparent;
            C1.ForeColor = SystemColors.ActiveCaptionText;
            C1.Location = new Point(94, 426);
            C1.Name = "C1";
            C1.Size = new Size(48, 24);
            C1.TabIndex = 160;
            C1.Text = "C1";
            C1.UseVisualStyleBackColor = false;
            // 
            // B5
            // 
            B5.AutoSize = true;
            B5.BackColor = Color.Transparent;
            B5.ForeColor = SystemColors.ActiveCaptionText;
            B5.Location = new Point(588, 360);
            B5.Name = "B5";
            B5.Size = new Size(48, 24);
            B5.TabIndex = 159;
            B5.Text = "B5";
            B5.UseVisualStyleBackColor = false;
            // 
            // B4
            // 
            B4.AutoSize = true;
            B4.BackColor = Color.Transparent;
            B4.ForeColor = SystemColors.ActiveCaptionText;
            B4.Location = new Point(469, 360);
            B4.Name = "B4";
            B4.Size = new Size(48, 24);
            B4.TabIndex = 158;
            B4.Text = "B4";
            B4.UseVisualStyleBackColor = false;
            // 
            // B3
            // 
            B3.AutoSize = true;
            B3.BackColor = Color.Transparent;
            B3.ForeColor = SystemColors.ActiveCaptionText;
            B3.Location = new Point(354, 360);
            B3.Name = "B3";
            B3.Size = new Size(48, 24);
            B3.TabIndex = 157;
            B3.Text = "B3";
            B3.UseVisualStyleBackColor = false;
            // 
            // B2
            // 
            B2.AutoSize = true;
            B2.BackColor = Color.Transparent;
            B2.ForeColor = SystemColors.ActiveCaptionText;
            B2.Location = new Point(228, 360);
            B2.Name = "B2";
            B2.Size = new Size(48, 24);
            B2.TabIndex = 156;
            B2.Text = "B2";
            B2.UseVisualStyleBackColor = false;
            // 
            // B1
            // 
            B1.AutoSize = true;
            B1.BackColor = Color.Transparent;
            B1.ForeColor = SystemColors.ActiveCaptionText;
            B1.Location = new Point(94, 360);
            B1.Name = "B1";
            B1.Size = new Size(48, 24);
            B1.TabIndex = 155;
            B1.Text = "B1";
            B1.UseVisualStyleBackColor = false;
            // 
            // A5
            // 
            A5.AutoSize = true;
            A5.BackColor = Color.Transparent;
            A5.ForeColor = SystemColors.ActiveCaptionText;
            A5.Location = new Point(588, 295);
            A5.Name = "A5";
            A5.Size = new Size(49, 24);
            A5.TabIndex = 154;
            A5.Text = "A5";
            A5.UseVisualStyleBackColor = false;
            // 
            // A4
            // 
            A4.AutoSize = true;
            A4.BackColor = Color.Transparent;
            A4.ForeColor = SystemColors.ActiveCaptionText;
            A4.Location = new Point(469, 295);
            A4.Name = "A4";
            A4.Size = new Size(49, 24);
            A4.TabIndex = 153;
            A4.Text = "A4";
            A4.UseVisualStyleBackColor = false;
            // 
            // A3
            // 
            A3.AutoSize = true;
            A3.BackColor = Color.Transparent;
            A3.ForeColor = SystemColors.ActiveCaptionText;
            A3.Location = new Point(354, 295);
            A3.Name = "A3";
            A3.Size = new Size(49, 24);
            A3.TabIndex = 152;
            A3.Text = "A3";
            A3.UseVisualStyleBackColor = false;
            // 
            // A2
            // 
            A2.AutoSize = true;
            A2.BackColor = Color.Transparent;
            A2.ForeColor = SystemColors.ActiveCaptionText;
            A2.Location = new Point(228, 295);
            A2.Name = "A2";
            A2.Size = new Size(49, 24);
            A2.TabIndex = 151;
            A2.Text = "A2";
            A2.UseVisualStyleBackColor = false;
            // 
            // A1
            // 
            A1.AutoSize = true;
            A1.BackColor = Color.Transparent;
            A1.ForeColor = SystemColors.ActiveCaptionText;
            A1.Location = new Point(94, 295);
            A1.Name = "A1";
            A1.Size = new Size(49, 24);
            A1.TabIndex = 150;
            A1.Text = "A1";
            A1.UseVisualStyleBackColor = false;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(661, 630);
            Controls.Add(txtto);
            Controls.Add(label6);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nameTextBox);
            Controls.Add(button1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(C5);
            Controls.Add(C4);
            Controls.Add(C3);
            Controls.Add(C2);
            Controls.Add(C1);
            Controls.Add(B5);
            Controls.Add(B4);
            Controls.Add(B3);
            Controls.Add(B2);
            Controls.Add(B1);
            Controls.Add(A5);
            Controls.Add(A4);
            Controls.Add(A3);
            Controls.Add(A2);
            Controls.Add(A1);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox C5;
        private System.Windows.Forms.CheckBox C4;
        private System.Windows.Forms.CheckBox C3;
        private System.Windows.Forms.CheckBox C2;
        private System.Windows.Forms.CheckBox C1;
        private System.Windows.Forms.CheckBox B5;
        private System.Windows.Forms.CheckBox B4;
        private System.Windows.Forms.CheckBox B3;
        private System.Windows.Forms.CheckBox B2;
        private System.Windows.Forms.CheckBox B1;
        private System.Windows.Forms.CheckBox A5;
        private System.Windows.Forms.CheckBox A4;
        private System.Windows.Forms.CheckBox A3;
        private System.Windows.Forms.CheckBox A2;
        private System.Windows.Forms.CheckBox A1;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        

        #endregion
    }
}