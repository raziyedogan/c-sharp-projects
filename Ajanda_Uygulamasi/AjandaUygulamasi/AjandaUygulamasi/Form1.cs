using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DLL_AjandaUygulamasý;

namespace AjandaUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ajanda ajanda = new ajanda();

            if (comboBox1.SelectedIndex == 0)
            {
                label3.Text = ajanda.pazartesi();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label3.Text = ajanda.sali();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label3.Text = ajanda.carsamba();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                label3.Text = ajanda.persembe();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                label3.Text = ajanda.cuma();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Pazartesi");
            comboBox1.Items.Add("Salý");
            comboBox1.Items.Add("Çarþamba");
            comboBox1.Items.Add("Perþembe");
            comboBox1.Items.Add("Cuma");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}