using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Versionprueba
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form3();
            form.Show();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form1();
            form.Show();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form4();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form5();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form6();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form form = new Form7();
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox1cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox2minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
