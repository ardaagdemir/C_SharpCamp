using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        //Burada toplama işlemini tekrar tekrar yapabilmek için bir metot oluşturarak class içerisinde çalıştırdık.
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç : " + toplam);
        }
    }
}
