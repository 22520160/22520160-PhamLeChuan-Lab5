using System;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
namespace Lab05
{
    public partial class Bai01 : Form
    {
        public Bai01()
        {
            InitializeComponent();
        }
        private async void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 465, true);
                    await client.AuthenticateAsync(textBoxFrom.Text.Trim(), "glvi qziv snfp omam");

                    var message = new MimeMessage
                    {
                        From = { new MailboxAddress("Tên người gửi", textBoxFrom.Text.Trim()) },
                        To = { new MailboxAddress("", textBoxTo.Text.Trim()) },
                        Subject = textBoxSubject.Text.Trim(),
                        Body = new TextPart("plain") { Text = richTextBoxBody.Text }
                    };
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }
                MessageBox.Show("Email đã được gửi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
