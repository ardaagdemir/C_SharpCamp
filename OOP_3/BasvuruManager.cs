using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class BasvuruManager
    {//Krediye basvuru almak için oluşturulan bir class tır.
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices) //basvuru yap kısmını aynı zamanda logla demektir
        {
            //Başvuran bilgilerini değerlendirme
            //
            //KonutKrediManager konutKrediManager = new KonutKrediManager(); //Bu şekilde yazıldığında tüm başvurular yalnızca konut kredisi üzerinden hesaplanır.
            krediManager.Hesapla(); //Yani tüm başvurular konut kredisine yapılmış gibi oldu.

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();  //birden çok logger yollayabilmek için yazılan bir kod bloğudur. aşağıdaki krediler için yapılan işlemin aynısıdır. Program.cs de tanımlanır
            }

            //Bunun için bu başvurunun hangi krediye göre yapılacağının belirlenmesi gerekir.
            //public void kısmına paramtre olarak bu tanıtılmalıdır.
        }
        //Birden fazla kredi tipinde farklı hesaplamalar yapmak için;
        //ilk önce liste oluşturulur
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)  //kredi tipinin sayısının belirli olmamasından dolayı bir list<> oluşturuyoruz ve türü de IKrediManager türündedir
        {
            foreach (var kredi in krediler)  //krediler parametresini çağırmış olduk
            {
                kredi.Hesapla();

            }
        }
    }
}
