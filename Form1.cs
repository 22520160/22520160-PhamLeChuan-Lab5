namespace Lab05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai01 f = new Bai01();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bai02 f = new Bai02();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bai04 f = new Bai04();
            f.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bai06 f = new Bai06();
            f.Show();
        }        
    }
}
