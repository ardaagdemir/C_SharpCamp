using System;
using System.Collections.Generic;
using System.Linq;

namespace _22_LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Bilgisayar"},
                new Category{CategoryId=2, CategoryName="Telefon"}
            };

            List<Product> products = new List<Product>
            {
                new Product{ProductId=1, CategoryId=1, ProductName="Acer Laptop", QuantityPerUnit="32 GB Ram", UnitPrice=10000, UnitInStock=5},
                new Product{ProductId=2, CategoryId=1, ProductName="Asus Laptop", QuantityPerUnit="16 GB Ram", UnitPrice=8000, UnitInStock=3},
                new Product{ProductId=3, CategoryId=1, ProductName="HP Laptop", QuantityPerUnit="8 GB Ram", UnitPrice=6000, UnitInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Samsung Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=5000, UnitInStock=15},
                new Product{ProductId=5, CategoryId=2, ProductName="Apple Telefon", QuantityPerUnit="4 GB Ram", UnitPrice=7000, UnitInStock=0}
            };


            //Linq kullanımı aşağıdaki şekildedir. Foreach ile satırlarca sürecek bir sorgulama yapmamak için linq kullanılır.
            var result = products.Where(product => product.UnitPrice > 5000 && product.UnitInStock > 3);

            foreach (var product in result)
            {
                Console.WriteLine(product.ProductName);
            }

            GetProducts(products); //Aşağıdaki kod bloğunu yazabilmek için burada products'ı kapsayan bir fonksiyon oluşturduk.
        }

        //Eğer linq kullanmayacaksak aşağıdaki gibi bir metot yazmamız gerekirdi.
        static List<Product> GetProducts(List<Product> products) //Burada bir filtreleme gerçekleştirdik. 
        {
            List<Product> filteredProducts = new List<Product>();

            foreach (var product in products)
            {
                if(product.UnitPrice>5000 && product.UnitInStock > 3)
                {
                    filteredProducts.Add(product);
                }

            }
            return filteredProducts;
        }

        //linq formatı aşağıdaki şekilde sağlanır.
        static List<Product> GetProdutcsLinq(List<Product> products)
        {
            return products.Where(product => product.UnitPrice > 5000 && product.UnitInStock > 3).ToList();  //foreach şartını burada where fonksiyonu sağlamaktadır. 
                                                                                                    //Bu fonksiyon var olan listeden faydalanarak arka planda yeni bir liste oluşturarak return edilmesini sağlıyor.
        //Burada .To.List() komutunu yazmazsak linq bir array gibi algılanmaktadır. Bu yüzden hata alınır. Array'i bir List' e çevirerek bu hatadan kurtulabiliriz.
        }


        class Product
        {
            public int ProductId { get; set; }
            public int CategoryId { get; set; } //Örneğin adı Bilgisayar olan kategorinin ismini bilişim diye değiştirmek gerekirse bütün categoryname leri değiştirmeniz gerekir.
                                                //Bundan dolayı ürüne bir categoryId vererek isim değişikliğini categoryId üzerinden yapabiliriz.
            public string ProductName { get; set; }
            public string QuantityPerUnit { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitInStock { get; set; }
        }

        class Category
        {
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
        }
    }
}
