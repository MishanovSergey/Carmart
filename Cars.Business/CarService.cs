using Cars.DAL;
using Cars.Domain.Models;
using System.Collections.Generic;

namespace Cars.Business
{
    public class CarService
    {
        private readonly CarRepository _carRepository;
        public CarService()
        {
            _carRepository = new CarRepository();
        }
        
        public List<Car> GetCarsByBrand(string brand)
        {
            return _carRepository.GetCarsByBrand(brand);
        }

        public List<Brand> GetAllBrands()
        {
            return _carRepository.GetAllBrands();
        }
    }
}