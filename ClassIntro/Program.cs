using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Umut";
            int yas = 18;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.KursunEgitmeni = "Umut Can Kibar";
            kurs1.IzlenmeOrani = 61;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.KursunEgitmeni = "Umut Can";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.KursunEgitmeni = "Çağrı Kibar";
            kurs3.IzlenmeOrani = 68;





            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.KursunEgitmeni);

            Kurs[] Kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (Kurs kurs in Kurslar)
            {
                //Console.WriteLine(kurs.KursAdi);
                Console.WriteLine(kurs.KursAdi + " : " + kurs.KursunEgitmeni);
            }

            Console.WriteLine("hello");


        }

        class Kurs
        {
            public string KursAdi { get; set; }     
            public string KursunEgitmeni { get; set; }

            public int IzlenmeOrani { get; set; }


        }
    }
}
