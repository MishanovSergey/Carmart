using Cars.Domain.Models;
using System;
using System.Collections.Generic;

namespace Cars.UI
{
    internal class ConsoleWriter
    {
        internal static void ShowGreetings()
        {
            Console.Clear();
            Console.Write($"$$$$$$$$$$$$$$$ |!|!| Магазин премиальных авто Twisted Metall: Fury Road |!|!| $$$$$$$$$$$$$$$ ");
        }

        internal static void ShowAllBrands(List<Brand> brands)
        {
            Console.WriteLine("\n\n\nНиже представленны доступные бренды автомобилей:");
            foreach (var brand in brands)
            {
                Console.WriteLine($"\r\n||{brand.Name}||\r\n");
            }
            Console.WriteLine("Введите желаемый бренд:\n");
        }
        
        internal static void ShowBrandError()
        {
           Console.Write("Данный бренд не представлен в нашем салоне! Введите бренд из списка доступных: ");
        }
        
    }
}
