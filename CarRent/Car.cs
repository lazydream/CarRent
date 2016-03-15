using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace CarRent
{
    [DataContract]
    public class Car
    {
        //private string model;
        //private string description;

        public Car(string model, string description)
        {
            Model = model;
            Description = description;
        }

        public Car()
        {

        }

        [DataMember]
        public string Model { get; private set; }
        [DataMember]
        public string Description { get; private set; }

        public override string ToString()
        {
            return Model;
        }
    }
}
