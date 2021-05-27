using CoffeeShopApp.Abstract;
using CoffeeShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopApp.Concrete
{
    public class StarbucsCustomerManager: BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucsCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if(_customerCheckService.CheckIfRealPerson(customer))
                base.Save(customer);
            else
               throw new Exception("Not a valid person");

            
        }
        
    }
}
