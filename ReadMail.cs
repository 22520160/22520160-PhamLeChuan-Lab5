using System;
using System.Windows.Forms;

namespace Lab05
{
    public partial class ReadMail : Form
    {
        private readonly string _emailContent;

        public ReadMail(string from, string to, string title, string emailContent)
        {
            InitializeComponent();
            labelFromName.Text = from;
            labelToMail.Text = to;
            labelTitle.Text = title;
            _emailContent = emailContent;
        }

        private void ReadMail_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = _emailContent;
        }
    }
}

