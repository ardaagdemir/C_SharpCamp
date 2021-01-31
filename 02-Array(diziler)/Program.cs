using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);

            //Yukarıdaki gibi stringleri tek tek çalıştırmak yerine bir liste içerisinde toplayarak çalıştırmak daha pratik olacaktır.
            //Sonradan yapılacak değişiklikleri her sayfada değiştirmek yerine liste içerisinde değiştirerek sonuca daha kolay ulaşabiliriz.

            //array - dizi
            string[] kurslar = new string[] { kurs1, 
                "Programlamaya başlangıç için temel kurs", 
                "Java", "Python", "C#" };


            //ForLoop
            for (int i = 0; i<kurslar.Length; i++) //0 dan başlayarak 1 er 1 er arttır(i++) ve kursların sayısına kadar döngüden çıkma.  //lenght=uzunluk, i++ -->1 er 1 er arttır.
                                                                                                                                                         //i+=1 veya 
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("For bitti");


            //foreach farklı bir döngü yöntemidir. For ile aynıdır. Ancak "foreach" yalnızca dizilere uygulanır ve yazım farkı vardır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu - footer");
        }
    }
}
