using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği ------>c# ve Java dilleri bu prensip ile çalışmaktadır.
            //Do not repeat yourself
            
            //Veri tipleri

            //int, decimal, float, double, bool gibi sayısal veri tiplerine "Değer Tip" adı verilir.
            //Bu değer tipler bellekte "Stack" alanına kaydedilir.
            
            //array, class, interface gibi metin veri tiplerine "Referans Tip" adı verilir.
            //Bu referans tipler bellekte "Heap" alanına kaydedilir.
            
            string kategoriEtiketi = "Kategoriler"; //string metinleri ifade eder.
            int ogrenciSayisi = 32000; //int tam sayıları ifade eder.
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = false; //boolen yalnızca 0 ve 1 (false ve true) çalıştırır.
            double dolarDun = 7.55;  //double ondalık sayıları ifade eder.
            double dolarBugun = 7.45;


            //Koşul Tipleri (if,else,else-if)

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("değişmedi butonu");
            }


            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }
            


        }
    }
}
