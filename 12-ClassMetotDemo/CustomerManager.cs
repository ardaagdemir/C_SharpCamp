using System;
using System.Collections.Generic;
using System.Text;

namespace _12_ClassMetotDemo
{
    class CustomerSpecification
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Tebrikler, Müşteri Başarıyla Eklendi: " + customer.CustomerName + customer.CustomerSurname); 
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Tebrikler, Müşteri Başarıyla Silindi: " + customer.CustomerName + customer.CustomerSurname);
        }

        public void CustomerList(Customer[] customer)
        {
            Console.WriteLine("---Müşteri Listesi---");
            foreach (var liste in customer)
            {
                Console.WriteLine("Customer Name: " + liste.CustomerName);
                Console.WriteLine("Customer Surname: "+ liste.CustomerSurname);
                Console.WriteLine("Customer Job: " + liste.CustomerJob);
                Console.WriteLine("Customer Age: " + liste.CustomerAge);
                Console.WriteLine("Customer Salary: " + liste.CustomerSalary);
                Console.WriteLine("Customer ID: " + liste.CustomerID);
                Console.WriteLine("Customer Phone: " + liste.CustomerPhoneNumber);
                Console.WriteLine(" ");
            }
        }
            

            
        
    }
}
