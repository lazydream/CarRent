using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CarRent
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public string Name { get; private set; }

        public Client(string name)
        {
            Name = name;
        }
    }
}
