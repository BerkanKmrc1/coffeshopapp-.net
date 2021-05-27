using CoffeeShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopApp.Abstract
{
    public abstract class  BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine("Save to db : "+ customer.Name);
        }
    }
}
