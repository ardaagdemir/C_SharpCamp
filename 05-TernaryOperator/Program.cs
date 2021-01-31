using System;

namespace _03_TernaryOperatörü
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ternary Operatörü Nedir?

            int a = 5, b = 4;

            //if (a>b)
            //{
            //    Console.WriteLine("5 sayısı 4 den büyüktür);
            //}
            //else
            //{
            //    Console.WriteLine("4 sayısı 5 den büyüktür);
            //} 

            //Ternary Operatörü if koşulunda satır satır yazılan kodların tek satırda yazmaya yarar.

            string sonuc = a > b ? "5 sayısı 4 den büyüktür" : "4 sayısı 5 den büyüktür";
            Console.WriteLine(sonuc);

        }
    }
}
