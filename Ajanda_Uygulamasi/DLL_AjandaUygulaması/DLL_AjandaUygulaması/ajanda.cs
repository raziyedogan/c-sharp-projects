namespace DLL_AjandaUygulaması
{
    public class ajanda
    {
        public string pazartesi()
        {
            string str1 = "PAZARTESİ DERS PROGRAMI:"+"\n"+"Otomata Teorisi (17:00) - Bilgisayar Mimarisi (19:00)";
            return str1;
        }

        public string sali()
        {
            string str2 = "SALI DERS PROGRAMI:" + "\n" + "Computer Network (20:00) - Biyoenformatik (21.00)";
            return str2;
        }

        public string carsamba()
        {
            string str3 = "ÇARŞAMBA DERS PROGRAMI:" + "\n" + "Mühendislik Etiği (14:00) - Algoritmalar (17:00)";
            return str3;

        }

        public string persembe()
        {
            string str4 = "PERŞEMBE DERS PROGRAMI:" + "\n" + "Database Systems (15:30) - Internet Based Programming (17:20)";
            return str4;
        }

        public string cuma()
        {
            string str5 = "CUMA DERS PROGRAMI:" + "\n" + "Veri Madenciliği (17:00) - Software Engineering  (19:00)";
            return str5;
        }
    }
}