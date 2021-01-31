using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //Yukarıda sayi1' in değeri, sayi2 ile eşitlendiği için 30 olarak değişmiştir. sayi2' nin değerinin eşitlemeden sonra değiştirilmesi sayi1 i etkilememiştir.
            //sayi1 ve sayi2 stack belleğine ayrı ayrı kayıt edilir. 
            //Bu durumda sayi1 ve sayi2 nin birbirine eşitlenmesinden sonra herhangi birinin değerinin değiştirilmesi sonucu değiştirmez.


            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //Yukarıdaki olay stack bellekte yani değer tiplerinde olan olaydan biraz daha farklıdır.
            //Burada sayilar1 ve sayilar2 eşitlendikten sonra sayilar2 nin indexlerinden herhangi birinin değiştirilmesi sayilar1 in indekslerini de değiştirir.
            //Bunun sebebi array olması yani referans tip olmasından kaynaklıdır.
            //Bir eşitleme yapıldığında buradaki dizilerin referans tipleri eşitlenmektedir.

            //                       stack                         heap
            //                      --------                     --------
            //referans no        (101)sayilar1               (101)[10,20,30]
            //  ""     ""        (102)sayilar2               (102)[100,200,300]
            //sayilar1 ve sayilar2 tanımlandığında "heap" belleğe yukarıdaki şekilde kaydedilir.(referans no lar temsilidir)
            //Daha sonra sayilar1 ile sayilar2 eşitlendiğinde;

            //                       stack                         heap
            //                      --------                     --------
            //referans no        (102)sayilar1               (101)[10,20,30]
            //  ""     ""        (102)sayilar2               (102)[100,200,300]
            //Yukarıdaki gibi sayilar1 in referans numarası sayilar2 ninkine eşitlenmiş olur. Bu da indexlerin eşitlenmesi anlamına gelmektedir.
            //101 referans numarasına ait kayıt ise bellekten silinir.

            //Daha sonra sayilar2 nin herhangi bir index değeri(örnekteki 0. indeks) değiştirildiğinde aynı referans numarasıyla kayıtlı olan sayilar1 inde index değeri değişir.
            //                       stack                         heap
            //                      --------                     --------
            //referans no        (102)sayilar1               (102)[999,200,300]
            //  ""     ""        (102)sayilar2               (102)[999,200,300]
            //Burada int[] sayilar1 = new int[] { 10, 20, 30 }; dizisindeki "new" string i, sayilar1 in veya istenilen int değerinin, "heap" belleğinde yeni(new) bir kayıt açmasını sağlamaktadır.
            //                       -----



        }
    }
}
