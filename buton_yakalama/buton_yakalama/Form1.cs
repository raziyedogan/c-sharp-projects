using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buton_yakalama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int time = 0;
        Random rnd = new Random();
        private void timer1_Tick(object sender, EventArgs e)
        {
            time++;
            int x = rnd.Next(1, width - 20);
            int y = rnd.Next(1, height - 70);
            button1.Location = new Point(x, y); ;

            label6.Text = time.ToString();
        }

        int width, height;

        private void button1_Click(object sender, EventArgs e)
        {
            int cnt = Convert.ToInt32(label2.Text);
            cnt++;
            label2.Text = cnt.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            width = this.Width;
            height = this.Height-50;
            timer1.Interval = 700;  //700 değerinin artırılması durumunda button daha yavaş hareket eder. Değerin azaltılması durumunda ise button daha hızlı hareket eder.
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            int cnt = Convert.ToInt32(label4.Text);
            cnt++;
            label4.Text = cnt.ToString();
        }

    }
}
