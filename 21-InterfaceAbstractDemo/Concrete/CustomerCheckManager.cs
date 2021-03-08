using _21_InterfaceAbstractDemo.Abstract;
using _21_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _21_InterfaceAbstractDemo.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
