using System;
using System.Collections.Generic;
using System.Text;

namespace _19_OOP_2
{
    class TuzelMusteri : Musteri 
     //"Musteri:" "Musteri class ında olan bütün özellikler bu class da vardır" anlamına gelir
     //Bütün classlarda aynı olacak özellikler Musteri class ında tanımlanır.

    {//özellik sınıfları
        public string SirketAdi { get; set; }
        public int VergiNo { get; set; }
    }
}
