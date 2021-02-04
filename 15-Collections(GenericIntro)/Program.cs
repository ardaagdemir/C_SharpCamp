using System;

namespace _15_Collections_GenericIntro_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generics (<>) kullanımı nedir?
            //Generic class, çalışılacak tipin kodlayıcı tarafından belirlendiği class çeşididir.

            //Eğer list class'ı olmasaydı bir koleksiyon nasıl yazılırdı?


            //MyList isimler = new MyList();  
            //Burada MyList class' ı bir "Generic" class'tır ve içerisinde bulunan metotlar tip bağımlı çalışmaktadır. 
            //Bundan dolayı MyList'e çalışılacak veri tipinin tanıtılması gerekiyor.

            MyList<string> isimler = new MyList<string>(); //metotlarda belirlediğimiz "T" burada bizim belirlemiş olduğumuz "string" dir.
            isimler.Add("Engin");
            Console.WriteLine(isimler);
        }
    }
}
