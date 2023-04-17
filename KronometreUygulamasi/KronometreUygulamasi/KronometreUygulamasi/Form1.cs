using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KronometreUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DateTime zaman;
        private void button1_Click(object sender, EventArgs e)
        {
            int saat = Convert.ToInt32(textBox1.Text);
            int dakika = Convert.ToInt32(textBox2.Text);
            int saniye = Convert.ToInt32(textBox3.Text);
            zaman = new DateTime(2023, 04, 17, saat, dakika, saniye);
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label4.Text = "00:00:00";
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman.AddSeconds(-1);
            label4.Text = zaman.ToString("HH:mm:ss");
            if (label4.Text == "00:00:00")
                timer1.Enabled = false;
        }
    }
}
