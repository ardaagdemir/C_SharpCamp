using _21_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using _21_InterfaceAbstractDemo.Entities;

namespace _21_InterfaceAbstractDemo.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Saved to db : " + customer.FirstName);
        }
    }
}
