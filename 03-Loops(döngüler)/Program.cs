using System;

namespace WhileLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı",
                "Programlamaya başlangıç için temel kurs",
                "Java", "Python", "C#" };


            //ForLoop
            for (int i = 0; i < kurslar.Length; i++) //0 dan başlayarak 1 er 1 er arttır(i++) ve kursların sayısına kadar döngüden çıkma.  //lenght=uzunluk, i++ -->1 er 1 er arttır.
                                                     //i+=1 veya 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");


            ///foreach farklı bir döngü yöntemidir. For ile aynıdır. Ancak "foreach" yalnızca dizilere uygulanır ve yazım farkı vardır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        



            //while döngüsü bir koşulun gerçekleşmesi bitene kadar sürecek sonsuz bir döngüdür.
            //Koşulun her kontrolünden sonra döngü içerisindeki işlemler birkez yapılır.
            //Sadece doğru durumlar için çalışır.

            //Başka bir deyişle;
            //While döngüsü, belirtilen koşul True olduğu sürece bir kod bloğu boyunca döngüyü çalıştırır.

            int a = 0;
            while (a < 5) //şart sağlandığı sürece koşul test edilir. kod bloğu çalışır.
            {
                Console.WriteLine(a);
                a++;
            }
        }
            //while ile for farkı;
            //for döngüsünde bir işin kaç kere yapılacağı programa bildirilir. Örneğin; kursların uzunluğu kadar döndür.
            //while döngüsünde ise bir koşul bildirilir ve bu koşul sağlandığı sürece döngü devam eder. Örneğin; i 5 den küçük olana kadar döndür.
    }
}
