using System;

namespace _04_Switch_CaseYapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch case yapısı, çok durumlu dallanma ifadelerinde if-else blokları yerine tercihen kullanılırlar. 
            //Switch-case ile yapılabilecek tüm işlemler if-else merdiveni ile de yapılabilmektedir. 
            //Fakat kod okunabilirliğini arttırdığı için birçok programcı switch-case yapısını karmaşık if-else blokları yerine kullanmaktadır.

            Console.WriteLine("Kaçıncı ayda olduğunuzu girin: ");
            int ay = Convert.ToInt32(Console.ReadLine());

            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                    Console.Write("Kış mevsimi");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.Write("İlkbahar mevsimi");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.Write("Yaz mevsimi");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.Write("Sonbahar mevsimi");
                    break;
                default:
                    Console.Write("Ay bilgisini yanlış girdiniz.");
                    break;
            }
        }
    }
}
