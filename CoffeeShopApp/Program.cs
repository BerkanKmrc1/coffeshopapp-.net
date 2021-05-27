using CoffeeShopApp.Abstract;
using CoffeeShopApp.Concrete;
using CoffeeShopApp.Entities;
using System;
using CoffeeShopApp.Adapters;

namespace CoffeeShopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager baseCustomerManager = new StarbucsCustomerManager(new MernisServiceAdapter());
            baseCustomerManager.Save(new Customer { DateOfBirth = new DateTime(1998,6,4),Name = "Berkan" ,LastNamed = "Kömürcü", NationalityId = "112313215"});
            Console.ReadLine();
        }
    }
    
}
