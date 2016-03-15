using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent
{
    public class CarService
    {
        public Car[] Cars { get; private set; }
        public List<Rent> Rents { get; private set; }
        private CarRentRepository _repository;

        public CarService(Car[] cars, CarRentRepository repository)
        {
            Cars = cars;
            _repository = repository;
        }

        public bool RentCar(Rent rent)
        {
            Rents = CarRentRepository.LoadCarRents().ToList();
            if (CheckIfCarRented(rent))
            {
                return false;
            }
            Rents.Add(rent);
            CarRentRepository.SaveCarRents(Rents.ToArray());
            return true;
        }

        private bool CheckIfCarRented(Rent rent)
        {
            Rent[] rentedCars = CarRentRepository.LoadCarRents();
            if (rentedCars.Length == 0)
            {
                return false;
            }
            else
            {
                foreach (Rent rentedCar in rentedCars)
                {
                    if (rent.Equals(rentedCar))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
