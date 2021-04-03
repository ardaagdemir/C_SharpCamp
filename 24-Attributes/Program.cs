using System;

namespace _24_Attributes
{
    class Program
    {
        //Attribute ler sayesinde merkezi bir noktada iş kuralları koyulur.
        //Örneğin müşterinin soyadının zorunlu olması gerektiğini, boş geçilemeyeceğini belirtmek gibi kurallar koyulabilir.
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, LastName = "Demiroğ", Age = 32 };
            CustomerDal customerDal = new CustomerDal();
            customerDal.Add(customer);
            Console.ReadLine();
        }

        //Dinamik sorgular üretmek için kullanılan bir attribute 
        //Attribute a parametre(Customers) yollayabilmek için bir constructor gerekir
        [ToTable("Customers")]
        class Customer
        {
            public int Id { get; set; }

            //First name girmesi zorunlu olsun
            [RequiredProperty]
            public string FirstName { get; set; }

            [RequiredProperty]
            public string LastName { get; set; }
            public int Age { get; set; }
        }

        
        class CustomerDal
        {
            //Obsolete hazır bir attribute
            //Obsolete = eski
            //Eski bir metot olduğunu belirtir
            [Obsolete("Don't use Add, instead use AddNew Method")]
            public void Add(Customer customer)
            {
                Console.WriteLine("{0}, {1}, {2}, {3} added!",
                customer.Id, customer.FirstName,customer.LastName, customer.Age);
            }

            public void AddNew(Customer customer)
            {
                Console.WriteLine("{0}, {1}, {2}, {3} added!",
                customer.Id, customer.FirstName, customer.LastName, customer.Age);
            }
        }

        //Attribute oluşturma
        //Attribute herkese kullanılabilir.
        //[AttributeUsage(AttribuTetargets.All)]

        //Attribute sadece class tarafından kullanılabilir. 
        //[AttributeUsage(AttribuTetargets.Class)

        //Attribute sadece property tarafından kullanılabilir.
        //[AttributeUsage(AttributeTargets.Property)

        //Attribute birden fazla yere uyuglanmak istenilirse 
        //[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)

        //Attribute Property yi birden fazla kullanmak için AllowMultiple yazılır.
        [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
        class RequiredPropertyAttribute : Attribute
        {

        }


        //Attribute parametresi için bir constructor oluşturmak gerekir.
        [AttributeUsage(AttributeTargets.Class)]
        class ToTableAttribute : Attribute
        {
            private string _tableName;

            public ToTableAttribute(string tableName)
            {
                _tableName = tableName;
            }
        }


    }
}
