using System;
using System.Collections.Generic;

namespace OOP_3
{
    class Program
    {
        static void Main(string[] args)
        {   //IKrediManager yazılabilir.
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            //IKrediManager yazılabilir.
            TasitKrediManager tasitKrediManager = new TasitKrediManager();

            //IKrediManager yazılabilir.
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            //interface ona implement edilen class ın (örneğin TasitKrediManager, IhtiyacKrediManager, KonutKrediManager gibi) referansını tutabilir.
            //Bu özelliği sayesinde yukarıda KonutKrediManager ya da diğerleri yerine bir interface olan IKrediManager' ı yazıo çalıştırabiliriz.

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();

            basvuruManager.BasvuruYap(ihtiyacKrediManager, new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() }); //yeni bir list oluşturularakta yapılabilir


            //Birden fazla kredi tipinde farklı hesaplamalar yapmak için;
            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager, tasitKrediManager, konutKrediManager};  //Boş bir liste oluşturmuş olduk.

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
