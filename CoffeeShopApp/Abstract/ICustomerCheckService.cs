﻿using CoffeeShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopApp.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
     
    }
}