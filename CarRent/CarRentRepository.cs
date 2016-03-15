using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;

namespace CarRent
{
    public class CarRentRepository
    {
        public static void SaveCarRents(Rent[] rents)
        {
            using (Stream fStream = new FileStream("carRentsDb.xml", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                DataContractSerializer dcSerializer = new DataContractSerializer(typeof(Rent[]));
                dcSerializer.WriteObject(fStream, rents);
            }
        }
        public static Rent[] LoadCarRents()
        {
            Rent[] rents;
            using (Stream fStream = new FileStream("carRentsDb.xml", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
            {
                DataContractSerializer dcSerializer = new DataContractSerializer(typeof(Rent[]));
                try
                {
                    rents = (Rent[])dcSerializer.ReadObject(fStream);
                    return rents;
                }
                catch(Exception)
                {
                    rents = new Rent[0];
                    return rents;
                }
            }
        }

        public static void SaveCars(Car[] cars)
        {
            using (Stream fStream = new FileStream("carsDb.xml", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                DataContractSerializer dcSerializer = new DataContractSerializer(typeof(Car[]));
                dcSerializer.WriteObject(fStream, cars);
            }
        }
        public static Car[] LoadCars()
        {
            Car[] cars;
            using (Stream fStream = new FileStream("carsDb.xml", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
            {
                DataContractSerializer dcSerializer = new DataContractSerializer(typeof(Car[]));
                cars = (Car[]) dcSerializer.ReadObject(fStream);
            }
            return cars;
        }
    }
}
