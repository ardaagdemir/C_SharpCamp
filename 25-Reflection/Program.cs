using System;
using System.Reflection;

namespace _25_Reflection
{
    //Reflection, kodun çalışma anında anlık olarak işlem yapabilme potansiyelini temsil eder.
    class Program
    {
        static void Main(string[] args)
        {
            //Bu işlemler önceden tanımlanmış işlemlerdir. Bunlar yerine Reflection kullanırsak farklı bir kod bloğu yazmamız gerekir.
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Sum2());
            //Console.WriteLine(dortIslem.Sum(3, 4));

            ////////////////////////////////////////////////////////////////////////////////////////////////
            //Reflection
            //var type = typeof(DortIslem);

            //Activator, yukarıdaki new metodu ile aynı özelliğe sahiptir.
            //Gelen type a göre bir obje döndür anlamına gelmektedir.

            //Activator.CreateInstance(type);
            //DortIslem dortIslem = (DortIslem)Activator.CreateInstance(type, 6, 7);

            //Parametreli kısımdır. Toplanacak parametreler ConsoleWriteLine da belirtilmiştir.

            //Console.WriteLine(dortIslem.Sum(4,5));
            //Parametresiz kısımdır. Activator' dan gelen parametreleri döndürür.
            //Console.WriteLine(dortIslem.Sum2());
            ///////////////////////////////////////////////////////////////////////////////////////////////
            


            //Reflection
            var type = typeof(DortIslem);
            
            //Daha profesyonel bir Reflection kullanımı aşağıdaki gibidir.
            var instance = Activator.CreateInstance(type, 7, 8);

            //instance' da GetType' a git ve "Topla2" metodunu çağır.
            //Bu metodun parametresi olmadığı için Invoke değeri "null" dur.
            //Bu değeri instance için çalıştır.

            //GetMethod ile istenilen methodaa ulaşılır.
            //Invoke ile o method çalıştırılır.

            MethodInfo methodInfo = instance.GetType().GetMethod("Sum2");
            Console.WriteLine(methodInfo.Invoke(instance, null));

            Console.WriteLine("------------------------------");

            //Reflection ile bir nesneye ait özelliklere liste şeklinde erişilebilir.
            var metodlar = type.GetMethods();

            //Metodların infolarını dönmeye yarayan kod bloğu
            foreach (var info in metodlar)
            {
                Console.WriteLine("Metot adı : {0}", info.Name);

                //Parametreleri görmeye yarayan kod bloğu
                foreach (var parametre in info.GetParameters())
                {
                    Console.WriteLine("Parametre : {0}", parametre.Name);
                }

                //Attribute infolarını görmeye yarayan kod bloğu
                foreach (var attribute in info.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute Name : {0}", attribute.GetType().Name);
                }
            }



            Console.ReadLine();
        }
    }

    public class DortIslem
    {
        int _sayi1;
        int _sayi2;
        public DortIslem(int sayi1, int sayi2)
        {
            _sayi1 = sayi1;
            _sayi2 = sayi2;
        }
        public int Sum(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public int Multip(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Sum2()
        {
            return _sayi1 + _sayi2;
        }


        [MetodName("Carpma")]
        public int Multip2()
        {
            return _sayi1 * _sayi2;
        }
    }

    public class MetodName : Attribute
    {
        public MetodName(string name)
        {

        }
    }

}
