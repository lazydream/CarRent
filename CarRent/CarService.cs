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

        public void RentCar(Rent rent)
        {
            Rents = CarRentRepository.LoadCarRents().ToList();
            if (CheckIfCarRented(rent))
            {
                return;
            }
            Rents.Add(rent);
            CarRentRepository.SaveCarRents(Rents.ToArray());
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
                foreach (var rentedCar in rentedCars)
                {
                    if (rentedCar.RentedCar == rent.RentedCar)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            return false;
        }
    }
}
