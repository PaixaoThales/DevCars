using DevCars.API.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCars.API.Persistence
{
    public class DevCarsDbContext
    {
        public DevCarsDbContext()
        {
            Cars = new List<Car> 
            { 
                new Car(1, "123ABC", "Honda", "Civic", 2021, 100000, "Cinza", new DateTime(2021, 1, 1)),
                new Car(2, "456ABC", "Toyota", "Corolla", 2021, 950000, "Azul", new DateTime(2020, 3, 4)),
                new Car(3, "789DEF", "BWM", "Aquele do NFS", 2010, 150000, "Azul Branco e outras muitas cores", new DateTime(2010, 10, 11)),
            };
            Customers = new List<Customer> 
            { 
                new Customer(1, "Thomas", "1234567", new DateTime(2001, 6 , 3)),
                new Customer(2, "Gabriel", "89101112", new DateTime(1990, 10 , 7)),
                new Customer(3, "Eric Soaress", "13141516", new DateTime(2001, 2 , 8)),
            };
        }

        public List<Car> Cars { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
