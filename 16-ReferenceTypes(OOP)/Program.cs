using System;

namespace _16_ReferenceTypes_OOP_
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();  
            Person person2 = new Person();
            person1.FirstName = "Engin"; //Buradaki kod bloğunda person1 ve 2 için yeni bir adres oluşturulduktan sonra person1 e bir string tanımlaması yapıldı.
                                         //Person2, person1 e eşitlendiğinde referans tip olduğu için person1' in adresine kaydedildi.
            person2 = person1;              
            person1.FirstName = "Derin";    //Bu işlemlerden sonra person1' de yapılan değişiklikler person2' yi de etkileyecektir. 

            Console.WriteLine(person2.FirstName);



            Customer customer = new Customer();  //Yukarıdaki durum burada da geçerlidir. Fakat burada farklı bir yazım tekniği kullanılmıştır.
            customer.FirstName = "Salih";
            customer.CreditCardNumber = "1234567";
            Employee employee = new Employee();  

            Person person3 = customer;  //Person bir "base class"tır. Base classlar(inheritence yapılan classlar) başka bir class parametresine eşitlenebilir.
            customer.FirstName = "Ahmet";   //Burada "Person" class ı, Customer class ında tanımlanan customer değişkenine eşitlenmiştir.
                                           //customer da yapılan bir değişiklik daha önce "Person" class ında tanımlanmamış olan person3 değişkenini etkileyecektir.
            Console.WriteLine(person3.FirstName); //customer değişkenine atanan değer artık person3 değişkenine aittir. 
                                                  //Buradaki temel mantık "reference type" mantığıdır.
                                                  //person3 yalnızca "Person" class ında tanımlı olduğu için CreditCardNumber gibi parametreleri tanımamaktadır. Bunları tanıyabilmesi için;

            Console.WriteLine(((Customer)person3).CreditCardNumber); //Customerda tanımlı bir parametreye ulaşmak için gerekli syntx buradaki gibidir.
            //Ancak diğer classlardaki customer ve employee değişkenleri "Person" class ından inheritence edildiği için "Person" class ında tanımlı olan id, firstname, lastname değişkenlerini tanımaktadır.


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }


    //base class : Person
    class Customer : Person   //inheritence = miras alma,  customer class a person class tan miras aldık
    {
        public string CreditCardNumber { get; set; }

    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }
}
