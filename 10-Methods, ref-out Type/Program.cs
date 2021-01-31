using System;

namespace _10__4._Gün_Hazırlık__Methods_
{
    class Program
    {
        static void Main(string[] args)
        {    
//metodu çağırmak için kullanılan blok:

          //var Result = Add2(20);

            int number1 = 20; 
            int number2 = 100;

          //var Result2 = Add3(number1, number2);    //number1 değeri bu satırda 20 dir.
            var Result2 = Num(ref number1, number2); 

            Console.WriteLine(Result2);

            Console.WriteLine(number1); 


          //Console.WriteLine(Result);
          //Console.ReadLine();
        }

        //metot
        static void Add()
        {
            Console.WriteLine("Added!");
        }
//Default parametre = 2 parametreli bir int methodda, parametrelerden biri verilmez ise bunun yerine sabit olan bir parametre kullanılır. Buna "default parametre" denir.
//Aşağıda number2 parametresinin default değerini 30 olarak ayarlarsak, normalde olduğu gibi yine 50 çıktısını gösterecektir.
//Ancak burada bir kural vardır. Default değerler her zaman methodun sonunda olması gerekmektedir. Ya da bütün parametrelerin default değerlerini yazmak gerekmektedir.
        static int Add2(int number1, int number2=30) //Add2 yi kullanan kişinin number1 ve number2 için iki tane parametre göndermesi gerekir.
        {                                           //"void" bir işlem yapmayı, bir yere bir şey yazdırmayı bir yerden bir şey çağırmayı hedefleyen bir kullanımdır
                                                   //Burada void yerine "int" kullanmalıyız. Çünkü girilen değerler "int" cinsinden ve sonuçta int cinsinden olmalıdır.
            var Result = number1 + number2;
            return Result;
            //return burada Result değerini döndürmek için kullanılmıştır.
        }


        static int Add3(int number1, int number2) //number1 bu satırda 30 dur.
        {
            number1 = 30;  //number1 değeri 20 den 30 olarak değiştirmiştir.
            return number1 + number2;
        }

        
//Yukarıda "Result2" yazdırıldığında "number1" değerinin 30 olarak toplama işlemine etki ettiğini gördük. Ancak "number1" değerinin kendisi yazdırıldığında 20 olarak dönmektedir.
//Bunun sebebi "number1" in bir değer tip olmasıdır ve değer tip değişmemektedir. Ancak belleğe tanımlanan diğer "number1"(metot içerisindeki-42. satır)' in değeri 30 olarak etki etmiştir.
//Eğer "number1" i yani değer tipi değiştirmek isteseydik burada "ref keyword" ünü kullanmamız gerekecekti.


        static int Num(ref int number1, int number2) 
        {
            number1 = 30; 
            return number1 + number2;
        }
    }   
//Bu durumda "number1" in değeri 30 olarak değişmiştir. ref keyword'ü değer tiplerinin referans tip gibi kullanılmasını sağlar.
//Bu ne gibi durumlarda kullanılabilir
//Örneğin bir kredi hesaplama yapılıyor ve sabit bir kredi oranı var. Ama müşteri durumuna göre bir miktar kredi indirimi uygulanabilir. Bunu yapabilmek için,
//İndirim yapılacağında(yani kredi oranı değiştiğinde == number1 in değişmesi gerekiyor) değer değişmesi gerektiğinden yeni değer ref olarak gönderiliyor.


    //ref e karşılık olarak bir de ""out keyword" ü vardır. 
    //Aralarındaki tek fark "ref keyword" kullanabilmek için belirli bir değer olması gerekirken(number1'in 20 olması gibi) "out keyword" de buna gerek yoktur.
    //
    //int number1; <<--------
    //int number2 = 100;

    //var Result3 = Num(out number1, number2);

    //Console.WriteLine(Result2);
    //Console.WriteLine(number1);

    //static int Num(out int number1, int number2)
    //  number1 = 30; ----> out kullanabilmek için mutlaka metodda return dan önce ilgili parametreye bir değer verilmesi gerekir. Yoksa kod çalışmaz.
    //  return number1 + number2;
    //

}
