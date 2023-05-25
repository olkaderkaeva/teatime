using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Derkaeva
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form2 newFrom = new Form2();
            newFrom.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form4 newFrom = new Form4();
            newFrom.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form5 newFrom = new Form5();
            newFrom.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form6 newFrom = new Form6();
            newFrom.Show();
        }
    }
}
