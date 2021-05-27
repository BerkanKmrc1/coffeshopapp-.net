using CoffeeShopApp.Abstract;
using CoffeeShopApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using ServiceReference2;

namespace CoffeeShopApp.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrulaAsync((Convert.ToInt64(customer.NationalityId), customer.Name.ToUpper(), customer.LastNamed.ToUpper(), customer.DateOfBirth.Year));

        }
    }
}
