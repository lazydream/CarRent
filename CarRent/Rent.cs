﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace CarRent
{
    [DataContract]
    public class Rent
    {
        [DataMember]
        public DateTime From { get; private set; }
        [DataMember]
        public DateTime To { get; private set; }
        [DataMember]
        public Client Name { get; private set; }
        [DataMember]
        public Car RentedCar { get; private set; }

        public Rent(DateTime from, DateTime to, Client name, Car rentedCar)
        {
            From = from;
            To = to;
            Name = name;
            RentedCar = rentedCar;
        }
        public Rent()
        {

        }
    }
}