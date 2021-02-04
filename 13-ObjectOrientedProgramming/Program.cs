using System;

namespace _13_ObjectOrientedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {   //Normalde aşağıdalanan veriler kullanıcı tarafından alınmaktadır.
            Product product1 = new Product();
            product1.ID = 1;
            product1.CategoryID = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //Aşağıda görülen syntx c_sharp'a sonradan eklenen bir özelliktir. Bu şekilde de tanımlanabilir.
            Product product2 = new Product {ID = 2, CategoryID = 5, UnitInStock = 5, ProductName ="Kalem", UnitPrice = 35};
            

            //----------stack-----------    -------heap---------   >>> hafızadaki temsili yerleri       
            ProductManager productManager = new ProductManager(); //Bu syntx' a "instance creation" denmektedir.
            //PascalCase   //camelCase   -----> yazım şekilleri
            productManager.Add(product1);

            Console.WriteLine(product1.ProductName);

            
        }
    }
}
