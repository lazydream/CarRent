using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent
{
    public class Car
    {
        public Car(string model, string description)
        {
            Model = model;
            Description = description;
        }

        public string Model { get; private set; }
        public string Description { get; private set; }

        public override string ToString()
        {
            return Model;
        }
    }
}
