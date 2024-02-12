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

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Mister1 m1 = new Mister1();
            m1.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Like l = new Like();
            l.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Brain1 b = new Brain1();
            b.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Skin s = new Skin();
            s.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Inter i = new Inter();
            i.Show();
        }
    }
}
