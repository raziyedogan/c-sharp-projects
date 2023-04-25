using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                int taban = Convert.ToInt32(textBox2.Text);

                label4.Text = TabanDonusum(sayi, taban).ToString();
            }

            catch(Exception ex)
            {
                label4.Text = ex.Message;
            }
        }

        int TabanDonusum(int sayi, int taban)
        {
            int basamak, sonuc = 0, us = 1;
            while(sayi >= 1)
            {
                basamak = sayi % taban;
                sayi = sayi / taban;
                sonuc += basamak * us;
                us *= 10;
            }

            return sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
