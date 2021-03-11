using System;
using System.Collections.Generic;
using System.Linq;

namespace _23_LinqMethods
{
    class Program
    {//Linq fonksiyonlarını öğrenmek için eğitim bloğu...
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryName = "Telefon", CategoryId = 1},
                new Category{CategoryName = "Televizyon", CategoryId = 2},
                new Category{CategoryName = "MutfakAletleri", CategoryId = 3}
            };

            List<Product> products = new List<Product>
            {
                new Product{Id = 1, Name = "Apple Phone", Price=1000, CategoryId = 1},
                new Product{Id = 2, Name = "Samsung Phone", Price=2000, CategoryId = 1},
                new Product{Id = 3, Name = "Huawei Phone", Price=2000, CategoryId = 1},
                new Product{Id = 4, Name = "Samsung TV", Price=2000, CategoryId = 2}
            };
            //
            //SINGLE LINE QUERY
            //

            //Any fonskyionu bir linq fonksiyonudur. Listede olan bir elemanı tam adıyla veya başka bir özelliği ile bulmaya yarar. Sonuç true ya da false olarak döner.
            var result = products.Any(p => p.Name == "Apple");
            Console.WriteLine(result);

            Console.WriteLine("--------------------");

            //Product class ındaki id si 1 olan ürünün türünü bulmamızı sağlar
            var result2 = products.Find(p=> p.Id == 1);

            Console.WriteLine(result2.Name);

            Console.WriteLine("--------------------");

            //FindAll verilen şarta uyan bütün ürünleri bulmaya yarar. Sonuç liste olarak döner. FindAll yerine Where fonksiyonu da kullanılarak forech ile döndürülebilir.
            var result3 = products.FindAll(p => p.Name.Contains("Pho")); //Contains == string fonksiyonu, isimlerinde ü olanları göstermemize yaramaktadır
            Console.WriteLine(result3);

            Console.WriteLine("--------------------");

            //Where fonksiyonu verilen şart doğrultusunda bütün satırları gezerek bir sonuç döndürür.
            var result4 = products.Where(p=> p.Id >= 2);
            foreach (var product in result4)
            {
                Console.WriteLine(product.Id);
            }

            Console.WriteLine("--------------------");

            //Where ile bir liste elemanının kendi içerisinde arama yapmak ve bunları sıralamak için aşağıdaki komut yazılabilir
            var result5 = products.Where(p => p.Name.Contains("Pho")).OrderByDescending(p => p.Price).ThenByDescending(p=> p.Name); //adının çerisinde Pho olanları bul ve bunları id ye göre aşağıdan yukarıya sırala
                                                                                                  // ve price ı aynı olanları z' den a'ya filtrele(ThenByDescending)
            foreach (var product in result5)
            {
                Console.WriteLine(product.Name);
            }

            Console.WriteLine("--------------------");

            //farklı bir linq yazımı -- classic linq
            var result6 = from p in products //products daki her bir elemandan(p) price ı 1500 den büyük olanları seç(select)
                          where p.Price>1500
                          select p;
            foreach (var product in result6)
            {
                Console.WriteLine(product.Name);
            }

            Console.WriteLine("--------------------");

            //yukarıdaki gibi her elemandan seçmek yerine ProductDetails ait belirlenmiş elemanlardan seçim yapabiliriz.
            //select p yerine yeni bir eleman listesi tanımlayabilriz
            var result7 = from p in products
                          where p.Price >= 1000
                          select new ProductDetails { CopyName = p.Name, CopyPrice = p.Price };
            foreach (var product in result7)
            {
                Console.WriteLine(product.CopyName);
            }

            Console.WriteLine("--------------------");

            //Yukarıda Product class ında var olan özelliklerden filtrelenmiş yeni bir class olan ProductDetails ı kullanarak, Product class ından verileri alabildik.
            //Ancak Product class ında olmayan, başka bir classta(örn: Category) olan özelliği almak için ne yapmalıyız?
            //Bunun için linq in "join" özelliğini kullanmamız gerekir.
            //Öncelikle bir tane nesne oluşturarak(ProductDetails) başlamalıyız. Category ve Product listelerini birbiriyle birleştirmemiz gerekiyor. Bu işleme "ilişkisel tasarım" denir. 
            var result8 = from p in products
                          join c in categories
                          on p.CategoryId equals c.CategoryId //Her iki listede de olan aynı eleman birbiri ile eşlenerek birleştirme yapılmış olur
                          select new ProductDetails { CopyId = p.Id, CopyName = c.CategoryName, CategoryName = p.Name, CopyPrice = p.Price };
            foreach (var productDetails in result8)
            {
                //Console.WriteLine(productDetails.CopyName + " " + productDetails.CategoryName);

               //Yukarıdakinden farklı bir yazım şekli (string interpolation)
                Console.WriteLine("{0} ---- {1}", productDetails.CopyName, productDetails.CategoryName);
            }
        }

        class ProductDetails
        {
            public string CopyName { get; set; }
            public int CopyId { get; set; }
            public decimal CopyPrice { get; set; }
            public string CategoryName { get; set; }
        }

        

        class Product
        {
            public string Name { get; set; }
            public int Id { get; set; }
            public decimal Price { get; set; }
            public int CategoryId { get; set; }
        }


        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
