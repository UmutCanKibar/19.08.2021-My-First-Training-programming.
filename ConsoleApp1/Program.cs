using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //type syfety -- tip güvenliği
            //kategoriEtiketi burada değer tutucu olarak kullanıldı yani alias
            string kategoriEtiketi = "kategori"; //metinsel yazılara basıtmak için
            int ogrenciSayisi = 32000; //Tam Sayıları bastırmak için kullanılır
            double faizOrani = 1.45; // hata verme sebebi eşittir işareti koymaman.
            bool sistemeGirisYapmısmi = true; //Kesirli Sayılar için kullanılır
            double dolarDun = 7.35;
            double dolarBugun = 7.45;


            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }



            if (sistemeGirisYapmısmi == true )
            {
                Console.WriteLine("Kullanıcı Ayarlar Butonu");
            }
            else 
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            

            Console.WriteLine(kategoriEtiketi);
 

        }
    }
}
