using System;

namespace _26_Delegates
{
    class Program
    {
        //Void olan ve parametre almayan operasyonlara delegelik(elçilik) yapmak için kullanılan kod
        //Delegate metodu, herhangi bir değişiklik yapmadan var olan mesajı iletmek ile görevlidir.
        public delegate void MyDelegate();//elçilik
        public delegate void MyDelegate2(string text);//elçilik

        //İki tane int eleman isteyen bir delegate
        public delegate int MyDelegate3(int number1, int number2);

        static void Main(string[] args)
        {
            //instanse
            CustomerManager customerManager = new CustomerManager();
            
            //Delegate1
            MyDelegate myDelegate = customerManager.SendMessage; //elçi
            myDelegate += customerManager.ShowAlert;//elçi
            myDelegate();
            //Delegate2
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2 += customerManager.ShowAlert2;
            myDelegate2("Hello");

            //instanse
            Matematik matematik = new Matematik();
            //Delegate
            MyDelegate3 myDelegate3 = matematik.Topla;
            myDelegate3 += matematik.Carp;
            var sonuc = myDelegate3(2, 3);
            Console.WriteLine(sonuc);
            //int döndüren bir delegate'de en son verilen değer ne ise o çalışacaktır.

            Console.ReadLine();

        }

        //Void ve parametre almayan metodlar
        public class CustomerManager
        {
            public void SendMessage() 
            { 
                Console.WriteLine("Hello!"); 
            }
              
            public void ShowAlert()
            {
                Console.WriteLine("Be careful!");
            }
            public void SendMessage2(string message)
            {
                Console.WriteLine(message);
            }

            public void ShowAlert2(string alert)
            {
                Console.WriteLine(alert);
            }
        }

        public class Matematik
        {
            public int Topla(int sayi1, int sayi2)
            {
                return sayi1 + sayi2;
            }

            public int Carp(int sayi1, int sayi2)
            {
                return sayi1 * sayi2;
            }
        }
    }
}
