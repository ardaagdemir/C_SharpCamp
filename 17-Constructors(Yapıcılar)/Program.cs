using System;

namespace _17_Constructors_Yapıcılar_
{
    class Program
    {
        static void Main(string[] args)
        //Buradaki kod satırına constructor denir. new edilen bir metoda constructor denir.
        {
            //Customer customer1 = new Customer { Id = 1, FirstName = "Arda", LastName = "Ağdemir", City = "Ankara" };  //bu şekilde yazılabilir.

            Customer customer2 = new Customer(1, "Arda", "Ağdemir", "Ankara"); //bu şekilde de yazılabilir.
            //Eğer yukarıdaki(customer2) gibi kullanmak isteniyorsa default customer da bu belirtilmelidir.
            //Burada bir çıktı alabilmemiz için değerleri set etmemiz gerekir.
            Console.WriteLine(customer2.FirstName);


            //Customer customer3 = new Customer(); //Bu yazım ve kullanım şekli, customer1 ile aynıdır. Eğer constructor kullanmak istiyorsak customer2 deki gibi kullanmamız gerekir.
            //customer3.FirstName = "Arda";
       
        }


        
    }

        


    class Customer
    {
        //bu syntx'a default constructor(parametresi olmayan) denir. Yazılmasa da arka planda çalışır.
        //bu bir özellik barındıran class türüdür
        public Customer(int id, string firstName, string lastName, string city) 
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
