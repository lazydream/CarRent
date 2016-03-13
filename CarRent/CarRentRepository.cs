using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent
{
    public class CarRentRepository
    {
        public void SaveCarRents(Rent[] rents)
        {
            using (StreamWriter writer = new StreamWriter("rentsdb.txt"))
            {
                foreach (var rent in rents)
                {
                    writer.WriteLine($"{rent.RentedCar}, в период с {rent.From} по {rent.To}, арендована клиентом {rent.Name}");
                }
            }

        }
    }
}
