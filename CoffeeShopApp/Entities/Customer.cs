using CoffeeShopApp.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoffeeShopApp.Entities
{
     public  class Customer:IEntity //customerın bir entity olduğunu belirtmek için bir interfaceden implement ettik
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string LastNamed { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string NationalityId { get; set; }
        }
}

