using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHA1_Algoritması_ile_Şifreleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sifreliMetin = sifreleGeriDonusumsuzSHA1(textBox1.Text);
            textBox2.Text = sifreliMetin;
        }

        public static string sifreleGeriDonusumsuzSHA1(string metin)
        {
            System.Security.Cryptography.SHA1 sifrele = new System.Security.Cryptography.SHA1CryptoServiceProvider();
            return Convert.ToBase64String(sifrele.ComputeHash(System.Text.Encoding.UTF8.GetBytes(metin)));
        }
    }
}
