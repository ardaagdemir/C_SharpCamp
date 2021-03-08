using _21_InterfaceAbstractDemo.Abstract;
using _21_InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace _21_InterfaceAbstractDemo.Concrete
{
    public class NerocustomerManager:BaseCustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public NerocustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                base.Save(customer);
            }
            else
            {
                throw new Exception("Not a valid person");
            }
            
        }
    }
}
