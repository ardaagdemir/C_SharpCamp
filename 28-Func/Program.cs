using System;

namespace _28_Func
{
    class Program
    {
        //Action' a ters olarak dönüş tipi olan parametreler için kullanılan bir mimaridir.
        static void Main(string[] args)
        {
            Func<int, int, int> add = Topla;
            Console.WriteLine(add(3,4));

            //Parametresiz metodlara delegasyon yapar ve sonucu int olarak gönderir.
            Func<int> getRandomNumber = delegate ()
            {
                //Random rastgele sayı üretmek için kullanılan bir C# kütüphanesidir.
                Random random = new Random();
                return random.Next(1, 100);
            };           

            //Farklı bir Func yazım şekli
            Func<int> getRandomNumber2 =()=> new Random().Next(1, 100);

            Console.WriteLine(getRandomNumber());
            Console.WriteLine(getRandomNumber2());
        }

        static int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
