using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using _21_InterfaceAbstractDemo.Entities;


namespace _21_InterfaceAbstractDemo.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
