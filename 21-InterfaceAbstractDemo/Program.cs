using _21_InterfaceAbstractDemo.Abstract;
using _21_InterfaceAbstractDemo.Adapters;
using _21_InterfaceAbstractDemo.Concrete;
using _21_InterfaceAbstractDemo.Entities;
using System;

namespace _21_InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NerocustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Engin", LastName = "Demiroğ", NationalityID = "28861499108" });
            Console.ReadLine();
        }
    }
}