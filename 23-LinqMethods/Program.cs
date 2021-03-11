using System;
using System.Collections.Generic;
using System.Linq;

namespace _23_LinqMethods
{
    class Program
    {//Linq fonksiyonlarını öğrenmek için eğitim bloğu...
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product{Name = "Apple Phone", Id = 1, Price=1000},
                new Product{Name = "Samsung Phone", Id = 2, Price=2000},
                new Product{Name = "Huawei Phone", Id = 3, Price=2000}
            };
            //
            //SINGLE LINE QUERY
            //

            //Any fonskyionu bir linq fonksiyonudur. Listede olan bir elemanı tam adıyla veya başka bir özelliği ile bulmaya yarar. Sonuç true ya da false olarak döner.
            var result = products.Any(p => p.Name == "Apple");
            Console.WriteLine(result);

            //Product class ındaki id si 1 olan ürünün türünü bulmamızı sağlar
            var result2 = products.Find(p=> p.Id == 1);
            Console.WriteLine(result2.Name);

            //FindAll verilen şarta uyan bütün ürünleri bulmaya yarar. Sonuç liste olarak döner. FindAll yerine Where fonksiyonu da kullanılarak forech ile döndürülebilir.
            var result3 = products.FindAll(p => p.Name.Contains("Pho")); //Contains == string fonksiyonu, isimlerinde ü olanları göstermemize yaramaktadır
            Console.WriteLine(result3);

            //Where fonksiyonu verilen şart doğrultusunda bütün satırları gezerek bir sonuç döndürür.
            var result4 = products.Where(p=> p.Id >= 2);
            foreach (var product in result4)
            {
                Console.WriteLine(product.Id);
            }

            //Where ile bir liste elemanının kendi içerisinde arama yapmak ve bunları sıralamak için aşağıdaki komut yazılabilir
            var result5 = products.Where(p => p.Name.Contains("Pho")).OrderByDescending(p => p.Price).ThenByDescending(p=> p.Name); //adının çerisinde Pho olanları bul ve bunları id ye göre aşağıdan yukarıya sırala
                                                                                                  // ve price ı aynı olanları z' den a'ya filtrele(ThenByDescending)
            foreach (var product in result5)
            {
                Console.WriteLine(product.Name);
            }
            Console.WriteLine("--------------------");
            //farklı bir linq yazımı
            var result6 = from p in products //products daki her bir üründen(p) price ı 1500 den büyük olanları seç(select)
                          where p.Price>1500
                          select p;
            foreach (var product in result6)
            {
                Console.WriteLine(product.Name);
            }
        }

        

        class Product
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public decimal Price { get; set; }
        }


        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
