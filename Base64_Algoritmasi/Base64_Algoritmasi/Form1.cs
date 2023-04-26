using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Base64_Algoritmasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifreliMetin = Sifrele(textBox1.Text);
            textBox2.Text = sifreliMetin;
            textBox3.Text = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string normalMetin = SifreCoz(textBox3.Text);
            textBox4.Text = normalMetin;
            textBox1.Text = textBox4.Text;
            
        }

        private static string Sifrele(string veri)
        {
            byte[] veriByteDizisi = System.Text.ASCIIEncoding.ASCII.GetBytes(veri);
            string sifrelenmisVeri = System.Convert.ToBase64String(veriByteDizisi);
            return System.Net.WebUtility.HtmlEncode(sifrelenmisVeri);
        }

        public static string SifreCoz(string cozVeri)
        {
            cozVeri = System.Net.WebUtility.HtmlDecode(cozVeri);
            byte[] cozByteDizi = System.Convert.FromBase64String(cozVeri);
            string orjinalVeri = System.Text.ASCIIEncoding.ASCII.GetString(cozByteDizi);
            return orjinalVeri;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
