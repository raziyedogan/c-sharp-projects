using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Öncelikle "MessagingToolkit.QRCode" kütüphanesi NuGet ekranından yüklenmiştir.

namespace karekod_olusturma_okuma
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

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = karekodOlustur(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data = karekodOku(pictureBox1.Image);
            label2.Text = data;
        }

        private string karekodOku(Image img)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            string text = decoder.Decode(new QRCodeBitmapImage(img as Bitmap));
            return text;
        }

        private Image karekodOlustur(string data)
        {
            MessagingToolkit.QRCode.Codec.QRCodeEncoder qe = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();
            qe.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qe.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            qe.QRCodeVersion = 4;
            System.Drawing.Bitmap bm = qe.Encode(data);
            return bm;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
