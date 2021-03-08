using System;

namespace _11_MethodOverloading
{
    class Program
    {
      //  static void Main(string[] args)
      //  {
      //      Console.WriteLine(Multiply(2,4));
      //      Console.WriteLine(Multiply(2, 4, 8));

      //      Console.WriteLine(Add(1,2,3,4,5,6)); //Burada girilen parametrelerin hepsi .Sum fonksiyonu sayesinde toplanır.

      //      Console.ReadLine(); //cmd de çalışmayı durdurmak için yazılmaktadır. Sadece sonucu görmek için kullanılır.
      //  }


      //  static int Multiply(int number1, int number2)
      //  {
      //      return number1 * number2;
      //  }

      //  //iki değil de üç sayı çarpmak istersek eğer aynı isimli fakat 3 parametreli bir method kullanabiliriz.
      //  //Bu duruma methods overloading(metodların aşırı yüklenmesi) denmektedir. 

      //  static int Multiply(int number1, int number2, int number3)
      //  {
      //      return number1 * number2 * number3;
      //  }
      //  //Yukarıdaki gibi yazıldığında iki metodda çağırıldığında çalışacaktır.

      //  //Ancak 10, 50, 100 sayı toplamak veya çarpmak istenildiğinde devamlı overloading yapılamaz.
      //  //Bunun için bir "params keyword" kullanılır.
      //  //static int Add(params int[] numbers) //"params" ile dizi formatında kaç tane isteniliyorsa o kadar parametre gönderilebilir.
      //                                       //"params" parametresinden önce birden fazla "int" parametresi eklenebilir. 
      //                                       //Ancak "params" parametresinden sonra herhangi bir parametre eklenemez. "params" son parametre olmalıdır.
      ////static int Add(int number, int number1, int number2 ...., params int[] numbers)
      //  {
      //      //return numbers.Sum();
      //      //.Sum bir toplama fonksiyonudur. Python ile aynıdır.
      //  }
    }   
}
