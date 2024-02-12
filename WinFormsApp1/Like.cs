using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Like : Form
    {
        public Like()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oops o = new Oops();
            this.Close();
            o.Show();
        }
    }
}
