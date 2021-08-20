using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type syfety -- tip güvenliği
            //kategoriEtiketi burada değer tutucu olarak kullanıldı yani alias
            string kategoriEtiketi = "kategori";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45; // hata verme sebebi eşittir işareti koymaman.
            bool sistemeGirisYapmısmi = false;


            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(ogrenciSayisi);
            Console.WriteLine(faizOrani);
            Console.WriteLine(sistemeGirisYapmısmi);
            Console.ReadLine();//eğer konsolda görünmesini istersen Readline yaz.

        }
    }
}
