using System;
using System.Windows.Forms;
using MimeKit;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;
using MailKit;
namespace Lab05
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }
        private async void buttonIMAP_Click(object sender, EventArgs e)
        {
            listViewMess.Clear();
            listViewMess.Columns.Add("Email", 300);
            listViewMess.Columns.Add("From", 200);
            listViewMess.Columns.Add("Date", 100);
            using (var client = new ImapClient())
            {
                try
                {
                    await client.ConnectAsync("imap.gmail.com", 993, true);
                    await client.AuthenticateAsync(textBoxEmail.Text.Trim(), textBoxPass.Text.Trim());

                    var inbox = client.Inbox;
                    await inbox.OpenAsync(FolderAccess.ReadOnly);

                    labelTotal_2.Text = inbox.Count.ToString();
                    labelRecent_2.Text = inbox.Recent.ToString();

                    for (int i = 0; i < Math.Min(4, inbox.Count); i++)
                    {
                        var message = await inbox.GetMessageAsync(i);
                        var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString() });
                        listViewMess.Items.Add(item);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    await client.DisconnectAsync(true);
                }
            }
        }
        private async void buttonPop3_Click(object sender, EventArgs e)
        {
            listViewMess.Clear();
            listViewMess.Columns.Add("Email", 300);
            listViewMess.Columns.Add("From", 200);
            listViewMess.Columns.Add("Date", 100);
            using (var client = new Pop3Client())
            {
                try
                {
                    await client.ConnectAsync("pop.gmail.com", 995, true);
                    await client.AuthenticateAsync(textBoxEmail.Text.Trim(), textBoxPass.Text.Trim());

                    labelTotal_2.Text = client.Count.ToString();

                    for (int i = 0; i < Math.Min(2, client.Count); i++)
                    {
                        var message = await client.GetMessageAsync(i);
                        var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString() });
                        listViewMess.Items.Add(item);
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    await client.DisconnectAsync(true);
                }
            }
        }
    }
}
