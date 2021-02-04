using System;
using System.Collections.Generic;
using System.Text;

namespace _13_ObjectOrientedProgramming
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product) //" Product class ından bir product(prodcut1 veya product2 gibi..) getir " demektir.
        {
            Console.WriteLine(product.ProductName + " eklendi");
        }
        public void Uptade(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi");
        }
        
        //void = Yapılacak işlem sonucu herhangi bir tip gerektirmiyorsa void kullanılır. 
        //Ancak sonuç bir "int", "string" veya herhangi bir başka değer tip ise sonuca göre "void" yerine bunlardan birini kullanılır.
        //void ile yazılan kodlarda elde edilen sonuçlar, return vb. gibi komutlar ile çalıştırılamadığından projenin herhangi bir yerinde tekrar kullanılamaz.
        //o yüzden tekrar tekrar kullanılacak durumlarda çıktıları o tipin şekline göre düzenlemek (yan sonuç/çıktı int ise ve daha sonra kullanılacaksa metot kısmında da int olmalıdır) gerekir.
    }
}
