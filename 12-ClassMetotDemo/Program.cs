using System;

namespace _12_ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.CustomerName = "Keanu";
            customer1.CustomerSurname = "Reeves";
            customer1.CustomerJob = "Actress";
            customer1.CustomerAge = 56;
            customer1.CustomerSalary = 20000;
            customer1.CustomerID = 123456789;
            customer1.CustomerPhoneNumber = 4321321;

            Customer customer2 = new Customer();
            customer2.CustomerName = "Margot";
            customer2.CustomerSurname = "Robbie";
            customer2.CustomerJob = "Actress";
            customer2.CustomerAge = 30;
            customer2.CustomerSalary = 30000;
            customer2.CustomerID = 987654321;
            customer2.CustomerPhoneNumber = 874652816;

            Customer[] customers = new Customer[] { customer1, customer2 };
            foreach (var customer in customers)
            {
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerSurname);
                Console.WriteLine(customer.CustomerJob);
                Console.WriteLine(customer.CustomerAge);
                Console.WriteLine(customer.CustomerSalary);
                Console.WriteLine(customer.CustomerID);
                Console.WriteLine(customer.CustomerPhoneNumber);
                Console.WriteLine("------------------------------------------");
            }

            CustomerSpecification customerSpecifications = new CustomerSpecification();
            customerSpecifications.Add(customer1);
            Console.WriteLine("------------------------------------------");
            customerSpecifications.Delete(customer2);
            Console.WriteLine("------------------------------------------");
            customerSpecifications.CustomerList(customers);
            Console.ReadLine();



        }
    }
}
