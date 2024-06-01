using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;

namespace Lab05
{
    public partial class SendMail : Form
    {
        public SendMail(string From, string Pass, string addrSMTP, string portSMTP)
        {
            InitializeComponent();
            txtfrom.ReadOnly = true;
            txtfile.ReadOnly = true;
            txtfrom.Text = From;
            this.Pass = Pass;
            this.addrSMTP = addrSMTP;
            this.portSMTP = portSMTP;
        }
        string Pass;
        string addrSMTP, portSMTP;
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                txtfile.Text = filePath;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect(addrSMTP, int.Parse(portSMTP), true);
                client.Authenticate(txtfrom.Text, Pass);
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(txtname.Text, txtfrom.Text));
                message.To.Add(new MailboxAddress("", txtto.Text));
                message.Subject = txtsubject.Text.Trim();

                message.Body = new TextPart();
                var bodyBuilder = new BodyBuilder();
                if (checkBoxHtml.Checked == true)
                {
                    bodyBuilder.HtmlBody = richTextBox1.Text;
                }
                else
                {
                    bodyBuilder.TextBody = richTextBox1.Text;
                }
                string filePath = txtfile.Text;
                if (!string.IsNullOrEmpty(filePath))
                {
                    bodyBuilder.Attachments.Add(filePath);
                }
                message.Body = bodyBuilder.ToMessageBody();

                client.Send(message);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }
        }
    }
}
