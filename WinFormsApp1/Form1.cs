namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Download d = new Download();
            d.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Juri j1 = new Juri();
            j1.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Juri j = new Juri();
            j.Show();
        }
    }
}
