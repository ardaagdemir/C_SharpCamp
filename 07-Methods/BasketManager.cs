using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class BasketManager
    {   //Metot Nedir? Ne İçin Kullanılır?

        //Program yazarken belirli bir işi yapan kod bloğunu birkaç kez kullanmak gerekebilir. 
        //Bunun için aynı kod bloğunu tekrar yazmak yerine bir "metot" olarak hazırlanır ve ihtiyaç duyulduğunda kullanılır.
        //Metotlar bir kez yazılarak birçok amaç için kullanılabilirler.

        public void Ekle(Product urun)//python da def fonksiyonu ile aynı yapıdır.
                                      //public void in parantez içerisine eklenenlere "parametre" denir.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
