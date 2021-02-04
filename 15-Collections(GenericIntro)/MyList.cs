using System;
using System.Collections.Generic;
using System.Text;

namespace _15_Collections_GenericIntro_
{
    class MyList <T> //0 elemanlı bir MyList oluşturmak için;
    {
        //Yukarıdaki "T" aşağıdaki public(metot tanımlama) kısmında parametre olarak "string item" veya sabit bir parametre girmek yerine, kodlayıcının kendisinin belirlemesine yarayan "Type" anlamına gelmektedir.
        //"item" parametresi değişkenlik gösterebilir. Kodlayıcının seçimine göre herhangi bir şey yazılabilir.

        T[] items; //Burayı metodun dışında yazmamızın sebebi  tek bir metoda atamadan, class içerisinde bütün metotlarda erişebilmektir.
        //constructor = bir class new edildiğinde çalışan bloğa denir. Metot adı class adı ile aynıdır.
        public MyList()
        {
            items = new T[0]; //"new string 0 elemanlı" anlamına gelmektedir.
                              //items ı bir new string e eşitleyerek referans numarasını değiştirmiş dolayısıyla items ın alacağı değerleri de sıfırlamış olduk
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Yukarıda new string e eşitlediğimiz items ın kendisini bellekte tutabilmek için tempArray(geçici dizi) adında ki bir değişkene atadık.
            items = new T[items.Length+1]; //0 eleman sayısı olan new T metodunun eleman sayısını 1 arttırmak için length fonksiyonu +1 kullanılır.
                                           //Fakat eleman sayısı 1 arttığında referans tip olduğu için bellekte 0 elemanlı olan items silinmiş olacak.
                                           //Bunu engellemek için "T[] tempArray = items" adlı bir kod yazmamız gerekecektir.
                                           //Bunun nedeni her çalıştırıldığında 1 artması gerektiğinden bir önceki eleman sayısına(örn 4 elemanken +1 komutuyla 5 eleman oluşturuldu) ait dizi bellekten silinecektir.
                                           //Bu dizi bellekten silinmesin diye tempArray adını verdiğimiz bir değişkene eşitleriz.

            for (int i = 0; i < tempArray.Length; i++) //1 arttırarak elde edilen tempArray elemanlarını tekrar items' a aktarmak için for döngüsü kullanılır.
            {
                items[i] = tempArray[i]; //tempArray'in i'nci elemanını, sırasıyla items'ın i'nci elemanına eşitle
            }

            items[items.Length - 1] = item;  //For döngüsü bittiğinde artık tempArray' in elemanları items' a aktarılmış olacak. Ve items da boş bir eleman kalmış olacak. Yani,
                                             //tempArray' e eşitlenen 0 elemanlı items'ın dizi uzunluğu 1 arttıktan sonra artık elimizde tempArray den 1 eleman fazla olan items bulunmuş olacak.
                                             //Artık eklenmek istenilen eleman için bir boşluk bulunmaktadır.
                                             //Yukarıdaki kod satırını yazarak (-1 son eleman demektir), 
                                             //items'ın boş olan alanına elemanı(public void Add(T item) kısmındaki "Add" metoduyla eklemek istediğimiz "item") ekleyebiliriz.

        }



    }
}
