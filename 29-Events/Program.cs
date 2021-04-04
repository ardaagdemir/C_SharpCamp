using System;

namespace _29_Events
{
    class Program
    {
        //Bir uygulamada bir hareket olduğunda o harekete ek oalrak yapılacak bir işlem var ise bu Event ile yapılabilir.
        //Örneğin bir e-tic mağazasında bulunan bir ürünün stoğu bitmeye yakın haber almak için Event kullanılabilir.
        //Eventler birer delegedir. Delege olmadan event kullanımı olamaz.
        static void Main(string[] args)
        {
            Product harddisk = new Product(50);
            harddisk.ProductName = "Hard Disk";

            Product gsm = new Product(50);
            gsm.ProductName = "GSM";
            gsm.StockControlEvent += Gsm_StockControlEvent;

            for (int i = 0; i < 10; i++)
            {
                harddisk.Sell(10);
                gsm.Sell(10);
                Console.ReadLine();
            }

            Console.ReadLine();
        }

        private static void Gsm_StockControlEvent()
        {
            Console.WriteLine("Gsm about to finish!!");
        }
    }
}
