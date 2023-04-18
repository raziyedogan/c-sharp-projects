using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Bir yazılıma ait veritabanından izin verildiği kadar veri çekme işlemi web servis yapıları kullanılarak yapılır. Web servisler web sitelerinde olduğu gibi herhangi bir
//sunucuda URL adresinde yayınlanırlar. Genellikle kullanan kişileri belirleyebilmek ve izinleri yönetebilmek için kullanıcı adı ve şifre bilgileri isterler.
//Öncelikle Solution Explorer penceresinde proje adı üzerine sağ tıklayarak Add menüsü altında bulunan Add Service Reference menüsüne tıklayınız. Açılan ekranda URL kısmına
//veri çekmek istediğiniz web servis sayfa adresini giriniz. Bu projede "http://data.altinkaynak.com/DataService.asmx" adresi kullanılmıştır. Bu adres, altın fiyatlarına
//erişime ücretsiz izin veren bir web servis sayfasıdır. Sonrasında URL girdiğiniz ekranda Namespace alanına bu web servis sayfası için "ServiceAltinKaynak" yazınız. 
//Ardından OK butonuna tıklayınız.


namespace web_servis_ile_veri_çekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServiceAltinKaynak.AuthHeader title = new ServiceAltinKaynak.AuthHeader();
            title.Username = "AltinkaynakWebServis";
            title.Password = "AltinkaynakWebServis";

            ServiceAltinKaynak.DataServiceSoapClient service = new ServiceAltinKaynak.DataServiceSoapClient();
            string result = service.GetCurrency(title);
            MessageBox.Show(result.ToString());
        }
    }
}
