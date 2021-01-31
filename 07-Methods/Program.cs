using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string urunAdi = "Elma";
            //double fiyati = 15;
            //string aciklama = "Amasya elması";
            //Class, yukarıdaki verileri tek başına aynı kod satırında tanımlamaya yarayan bir yapıdır.
            //Aşağıda örneği gösterilmiştir.

            //string[] meyveler = new string[] {"Elma","Karpuz" };

            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Product[] urunler = new Product[] {urun1,urun2 };

            //type-safe -- tip güvenli
            foreach (var urun in urunler)
            {                
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("--------------------");
            }

            Console.WriteLine("------------Metotlar---------------");
            //Aşağıdaki yapıya encapsulation(kapsülleme) denir.
            //Oluşturulan bir sınıf (class) içerisinde kullanıcının işlemlerini daha kolay gerçekleştirebilmesi için bazı işlemler birleştirilerek tek bir işlem gibi gösterilir. 
            //Bu birleştirme işlemine kapsülleme denir.
            BasketManager basketManager = new BasketManager();
            basketManager.Ekle(urun1);
            basketManager.Ekle(urun2);

        
        }
    }
}


//Dont repeat yourself - DRY - Clean Code - Best Practice
