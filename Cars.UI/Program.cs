using Cars.Business;
using Cars.Domain.Models;
using System;

namespace Cars.UI
{

    class Program
    {
        static void Main(string[] args)
        {
            var carService = new CarService();
            var brands = carService.GetAllBrands();
            ConsoleWriter.ShowGreetings();
            ConsoleWriter.ShowAllBrands(brands);
            string brandName = ConsoleReader.GetBrandName();
            while (true)
            {
                var isMatch = Validator.CheckBrandName(brandName, brands);
                if (isMatch)
                {
                    break;
                }
                ConsoleWriter.ShowBrandError();
                brandName = ConsoleReader.GetBrandName();
            }
            var cars = carService.GetCarsByBrand(brandName);

            foreach (Car car in cars)
            {
                Console.WriteLine(car.Brand.Name);
                Console.WriteLine(car.CarModel.Name);
                Console.WriteLine(car.CarModel.EngineVolume);
                Console.WriteLine(car.CarModel.TransmissionType);
                Console.WriteLine(car.CarModel.EngineType);
                Console.WriteLine(car.CarModel.BodyType);
                Console.WriteLine(car.CarModel.EnginePower);
            }

            Console.ReadLine();
            //while (true)
            //{
            //    string brandName = GetBrandName();


            //    string brandchoise = Cars.MainMenu(); //brandName нейминг
            //    decimal modellchoise = Logger.Modellogger(brandchoise);
            //    if (modellchoise == 0)
            //    {
            //        Logger.Backer(ref brandchoise, ref modellchoise);
            //    }
            //    string result = Logger.Buing(modellchoise); //Buy методы это всегда глаголы infinitive
            //    if (result == "продано") //лучше сделать bool isSold
            //        break;
            //
	//}
        }

       
    }
}
