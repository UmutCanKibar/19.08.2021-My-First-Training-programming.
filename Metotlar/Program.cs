using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması ";

            
                

            string[] meyveler = new string[] {"Elma","Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Adana karpuzu";


            Urun[] urunler = new Urun[] {urun1,urun2 };
            //Type Safe - tip güvenli
            foreach (Urun urun in urunler)
            {

                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------");

            }


            Console.WriteLine("-----Metotlar-------");
            //encapsulation
            //instance-örnek
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetmanager.Ekle2("Elma", "Yeşil Elma", 10, 18);
            sepetmanager.Ekle2("Karpuz", "Yeşil Karpuz", 80, 20);   







        }
    }
}
//Dont repeat yourself - DRY - Clean Code - Best Pratice
