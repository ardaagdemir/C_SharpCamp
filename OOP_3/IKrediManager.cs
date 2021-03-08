using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_3
{
    interface IKrediManager  //okunurluğu arttırmak için ana kelimenin başına "I" harfi koyulur.
    //class KrediManager
    //interface lerde kod bloğuna yalnızca imza koyulur.

    {//Bir bankadan kredi çekileceğinde çekilecek kredinin geri ödemesinin belirlenmesi için burada her kredi için ayrı ayrı işlem yapmak yerine inheritance kullanabiliriz.
     //Fakat her kredinin hesaplaması kendine özgü olacağından aşağıdaki Hesapla komutunu farklı ele almalıdır.
     //İmzanın(void Hesapla kısmına imza denmektedir) aynı olduğu fakat içeriğinin farklı olduğu durumlarda "class" yerine "interface" tanımlamamız gerekir
        void Hesapla();
        //Interface kullanılacağı zaman içerisinde kayıt edilmiş bütün metotlarında kullanılması gerekir
        void BiseyYap();
    }
}
