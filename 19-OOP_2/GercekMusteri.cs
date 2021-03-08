using System;
using System.Collections.Generic;
using System.Text;

namespace _19_OOP_2
{
    class GercekMusteri : Musteri 
     //"Musteri" "Musteri class ında olan bütün özellikler bu class da vardır" anlamına gelir
     //Bütün classlarda aynı olacak özellikler Musteri class ında tanımlanır.

    {//özellik sınıfları
        
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        

    }
}
