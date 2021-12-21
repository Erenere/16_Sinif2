using System;

namespace Sinif1_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Calisan1******");
            Calisan calisan1 = new Calisan("Ayse","Kara",2569921,"Insan Kaynaklari");
            calisan1.CalisanBilgileri();
            
            Console.WriteLine("*******Calisan2********");
            
            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 2563931;
            calisan2.Departman = "Satin Alma";
            
            calisan2.CalisanBilgileri();

            Console.WriteLine("******Calisan3*******");
            Calisan calisan3 = new Calisan("Eren", "Acik");
            calisan3.CalisanBilgileri();
        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan(string ad, string soyad, int no, string departman)
            {
                Ad = ad;
                Soyad = soyad;
                No = no;
                Departman = departman;
            }
            
            public Calisan(string ad, string soyad)
            {
                Ad = ad;
                Soyad = soyad;
            }
            
            public Calisan(){}
            
            public void CalisanBilgileri()
            {
                Console.WriteLine("Calisanin adi: {0}",Ad);
                Console.WriteLine("Calisanin soyadi: {0}",Soyad);
                Console.WriteLine("Calisanin numarasi: {0}",No);
                Console.WriteLine("Calisanin departmani: {0}",Departman);
            }
        }
    }
}