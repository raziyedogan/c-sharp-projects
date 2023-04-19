using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace donanim_bilgilerini_ogrenme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("MAC Adresi");
            comboBox1.Items.Add("Ip Adresi");
            comboBox1.Items.Add("Exe Oluşturulma Tarihi");
            comboBox1.Items.Add("İşlemci Bilgileri");
            comboBox1.Items.Add("Hard Disk Bilgileri");
            comboBox1.Items.Add("RAM Bilgileri");
            comboBox1.Items.Add("Ekran Kartı Bilgileri");
            comboBox1.Items.Add("İşletim Sistemi Bilgileri");
        }

        private string MACAdresiDondur()
        {
            string macadress = string.Empty;
            string mac = null;
            try
            {
                foreach(System.Net.NetworkInformation.NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                {
                    System.Net.NetworkInformation.OperationalStatus ot = nic.OperationalStatus;
                    if(nic.OperationalStatus == OperationalStatus.Up)
                    {
                        macadress = nic.GetPhysicalAddress().ToString();
                        break;
                    }
                }
                //mac adresi aralarına ayrım işareti eklemek için
                for(int i=0; i<=macadress.Length; i++)
                {
                    mac = mac + ":" + macadress.Substring(i, 2);
                    i++;
                }
                mac = mac.Remove(0, 1);
            }
            catch
            {

            }
            return mac;
        }

        private string IpAdresiDondur()
        {
            string host = System.Net.Dns.GetHostName();
            System.Net.IPHostEntry ip = System.Net.Dns.GetHostByName(host);
            return ip.AddressList[0].ToString();
        }

        private string ExeOlusturulmaTarihiDondur()
        {
            DateTime buildDate = new FileInfo(System.Reflection.Assembly.GetExecutingAssembly().Location).LastWriteTime;
            return buildDate.ToString();
        }

        private string IslemciBilgileriDondur()
        {
            string islemciID = "";
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM WIN32_Processor");
            ManagementObjectCollection mObject = searcher.Get();
            foreach(ManagementObject obj in mObject)
            {
                islemciID = obj["ProcessorId"].ToString();
            }
            return islemciID;
        }

        private string HardDiskBilgileriDondur()
        {
            string hardDiskBilgileri = "";
            var searcher = new System.Management.ManagementObjectSearcher("SELECT * FROM WIN32_DiskDrive");
            foreach(System.Management.ManagementObject wmi_HD in searcher.Get())
            {
                hardDiskBilgileri += "Model: " + wmi_HD["Model"].ToString().Trim();
                hardDiskBilgileri += ",Arayüz Türü: " + wmi_HD["InterfaceType"].ToString().Trim();
                hardDiskBilgileri += ",Başlık: " + wmi_HD["Caption"].ToString().Trim();
                hardDiskBilgileri += ",Seri No:" + wmi_HD.GetPropertyValue("SerialNumber").ToString().Trim();
            }
            return hardDiskBilgileri;
        }

        private string RAMBilgileriDondur()
        {
            ManagementObjectSearcher Search = new ManagementObjectSearcher("SELECT * FROM WIN32_ComputerSystem");
            string ram = "";
            foreach(ManagementObject Mobject in Search.Get())
            {
                double Ram_Bytes = (Convert.ToDouble(Mobject["TotalPhysicalMemory"]));
                double ramGB = Ram_Bytes / 1073741824;
                double islem = Math.Ceiling(ramGB);
                ram = islem.ToString() + "GB";
            }
            return ram;
        }

        private string EkranKartiBilgileriDondur()
        {
            ManagementObjectSearcher ekran = new ManagementObjectSearcher("SELECT * FROM WIN32_VideoController");
            string bilgiler = "";
            foreach(ManagementObject Mobject in ekran.Get())
            {
                bilgiler = "Sürücü Versiyonu: " + Mobject["DriverVersion"].ToString() + "Date: " + Mobject["DriverDate"].ToString().Substring(0, 8) + "Boyut: " + Mobject["name"].ToString() + " " + Mobject["AdapterRam"].ToString();
            }
            return bilgiler;
        }

        private string IsletimSistemiBilgileriDondur()
        {
            return System.Environment.OSVersion.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sonuc = "";
            if (comboBox1.Text == "MAC Adresi")
                sonuc = MACAdresiDondur();
            else if (comboBox1.Text == "Ip Adresi")
                sonuc = IpAdresiDondur();
            else if (comboBox1.Text == "Exe Oluşturulma Tarihi")
                sonuc = ExeOlusturulmaTarihiDondur();
            else if (comboBox1.Text == "İşlemci Bilgileri")
                sonuc = IslemciBilgileriDondur();
            else if (comboBox1.Text == "Hard Disk Bilgileri")
                sonuc = HardDiskBilgileriDondur();
            else if (comboBox1.Text == "RAM Bilgileri")
                sonuc = RAMBilgileriDondur();
            else if (comboBox1.Text == "Ekran Kartı Bilgileri")
                sonuc = EkranKartiBilgileriDondur();
            else if (comboBox1.Text == "İşletim Sistemi Bilgileri")
                sonuc = IslemciBilgileriDondur();
            label2.Text = sonuc;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
