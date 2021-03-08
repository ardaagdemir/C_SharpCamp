using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class TasitKrediManager : IKrediManager //interface tanımlandığında içeriği tanımlanmadığı için program hata oalrak görecektir. Ampule tıklayarak "Implement Interface" seçilir. 
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt kredisi ödeme planı hesaplandı.");
        }
    }
}
