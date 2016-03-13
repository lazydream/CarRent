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
        private List<Rent> _rents;
        private CarRentRepository _repository;

        public CarService(Car[] cars, CarRentRepository repository)
        {
            Cars = cars;
            _repository = repository;
        }

        public void RentCar(Rent rent)
        {
            if (CheckIfCarRented(rent))
            {
                return;
            }
            _rents.Add(rent);
            _repository.SaveCarRents(_rents.ToArray());
        }

        private bool CheckIfCarRented(Rent rent)
        {
            // Проверить, что машина свободна на время аренды
            return false;
        }
    }
}
