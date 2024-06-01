using MailKit.Net.Imap;
using System;
using System.Linq;
using System.Windows.Forms;
namespace Lab05
{
    public partial class Bai06 : Form
    {
        private readonly ImapClient _client;
        public Bai06()
        {
            InitializeComponent();
            _client = new ImapClient();
            SetControlsState(false);
        }
        private void SetControlsState(bool isLoggedIn)
        {
            txtEmail.ReadOnly = isLoggedIn;
            txtmatkhau.ReadOnly = isLoggedIn;
            txtimap.ReadOnly = isLoggedIn;
            txtimapport.ReadOnly = isLoggedIn;
            txtsmtp.ReadOnly = isLoggedIn;
            txtsmtpport.ReadOnly = isLoggedIn;
            buttonRefresh.Enabled = isLoggedIn;
            buttonSendMail.Enabled = isLoggedIn;
            buttonSignIn.Text = isLoggedIn ? "Đăng xuất" : "Đăng nhập";
        }
        private void ConnectToServer()
        {
            txtimap.Text = string.IsNullOrEmpty(txtimap.Text) ? "imap.gmail.com" : txtimap.Text;
            txtimapport.Text = string.IsNullOrEmpty(txtimapport.Text) ? "993" : txtimapport.Text;
            txtsmtp.Text = string.IsNullOrEmpty(txtsmtp.Text) ? "smtp.gmail.com" : txtsmtp.Text;
            txtsmtpport.Text = string.IsNullOrEmpty(txtsmtpport.Text) ? "465" : txtsmtpport.Text;
            try
            {
                _client.Connect(txtimap.Text, int.Parse(txtimapport.Text), true);
                _client.Authenticate(txtEmail.Text, txtmatkhau.Text);
                LoadEmails();
                SetControlsState(true);
            }
            catch (Exception)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DisconnectFromServer()
        {
            try
            {
                if (_client.IsConnected)
                {
                    _client.Disconnect(true);
                    MessageBox.Show("Đã đăng xuất");
                }
                else
                {
                    MessageBox.Show("Không có kết nối đến server");
                }
                ResetLoginForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void LoadEmails()
        {
            listView1.Clear();
            listView1.Columns.Add("Email", 300);
            listView1.Columns.Add("From", 200);
            listView1.Columns.Add("Date", 150);
            var inbox = _client.Inbox;
            inbox.Open(MailKit.FolderAccess.ReadOnly);
            for (int i = 0; i < Math.Min(inbox.Count, 20); i++)
            {
                var message = inbox.GetMessage(i);
                var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString(), message.HtmlBody });
                listView1.Items.Add(item);
            }
        }
        private void ResetLoginForm()
        {
            txtEmail.Clear();
            txtmatkhau.Clear();
            txtimap.Clear();
            txtimapport.Clear();
            txtsmtp.Clear();
            txtsmtpport.Clear();
            listView1.Clear();
            SetControlsState(false);
        }
        private void buttonSendMail_Click(object sender, EventArgs e)
        {
            var sendMail = new SendMail(txtEmail.Text, txtmatkhau.Text, txtsmtp.Text, txtsmtpport.Text);
            sendMail.Show();
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            LoadEmails();
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (buttonSignIn.Text == "Đăng xuất")
            {
                DisconnectFromServer();
            }
            else
            {
                ConnectToServer();
            }
        }
        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected && listView1.SelectedItems.Count > 0)
            {
                var selectedItem = e.Item;
                var subject = selectedItem.SubItems[0].Text;
                var from = selectedItem.SubItems[1].Text;
                var emailContent = selectedItem.SubItems[3].Text;

                var readMailForm = new ReadMail(from, txtEmail.Text, subject, emailContent);
                readMailForm.Show();
            }
        }
    }
}
