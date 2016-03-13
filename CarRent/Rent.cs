using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent
{
    public class Rent
    {
        public DateTime From { get; private set; }
        public DateTime To { get; private set; }
        public Client Name { get; private set; }
        public Car RentedCar { get; private set; }

        public Rent(DateTime from, DateTime to, Client name, Car rentedCar)
        {
            From = from;
            To = to;
            Name = name;
            RentedCar = rentedCar;
        }
    }
}
