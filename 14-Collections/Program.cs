using System;
using System.Collections.Generic;

namespace _14_Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] { "Engin", "Murat", "Ayşe", "Arda" };
            //Yukarıdaki diziye 4. eleman eklenmek istendiğinde bu mümkün olmamaktadır. 
            //Dizilerin immutability(değişmezlik) özellikleri vardır.
            //Bu durumun önüne geçebilmek için koleksiyonlar kullanılır.

            List<string> isimler2 = new List<string> { "Engin", "Murat", "Ayşe", "Arda" };
            //Koleksiyonlar yukarıdaki şekilde oluşturulur(listeler)
            //list özelliğini aktif edeiblmek için yukarıda görülen "using System.Collections.Generic;" kod bloğuna eklenmelidir.
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            //listeye bir eleman eklemek için;
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            //Dizilerde karşılaştığımız ekleme sorunu listeler kullanılarak giderilmiş olur.

            

        }
    }
}
