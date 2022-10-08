using Cars.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace Cars.DAL
{
    public class CarRepository
    {
        private List<Car> Cars = new List<Car>
        {
            new Car
            {
                Brand = new Honda(),
                CarModel = new CarModel()
                {
                    Name = "civic",
                    EngineType = 1,
                    EngineVolume = 2.5f,
                    EnginePower = 188,
                    TransmissionType = "6-ти ступенчатый классический автомат",
                    BodyType = "Хэтчбэк",
                    Price = 1959000.00M
                }
            },
            new Car
            {
                Brand = new Honda(),
                CarModel = new CarModel()
                {
                    Name = "civic",
                    EngineType = 1,
                    EngineVolume = 2.5f,
                    EnginePower = 188,
                    TransmissionType = "6-ти ступенчатый классический автомат",
                    BodyType = "Хэтчбэк",
                    Price = 1959000.00M
                }
            },
        };

        public List<Brand> GetAllBrands()
        {
            return new List<Brand>
            {
                new Honda(),
                new Ford(),
                new Kia(),
                new Volvo(),
            };
        }

        public List<Car> GetCarsByBrand(string brandName)
        {
            var cars = new List<Car>();
            foreach (var car in Cars)
            {
                if (car.Brand.Name.ToLower() == brandName)
                {
                    cars.Add(car);
                }
            }
            return cars;
        }
    }
}