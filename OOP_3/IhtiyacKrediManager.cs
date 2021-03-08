using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    class IhtiyacKrediManager : IKrediManager //interface tanımlandığında içeriği tanımlanmadığı için program hata oalrak görecektir. Ampule tıklayarak "Implement Interface" seçilir. 
    {
        public void BiseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi ödeme planı hesaplandı.");
        }
    }
}
