using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.UI
{
    class Logger
    {
        public static void Backer(ref string brand, ref decimal model)
        {
            while (true)
            {
                brand = Cars.MainMenu();
                model = Modellogger(brand);
                if (model != 0)
                {
                    break;
                }
            }
        }
        public static decimal Modellogger(string brand)
        {
            while (true)
            {

                switch (brand)
                {
                    case "hyundai":
                        return Hyundai.HyundaiMenu();
                    case "kia":
                        return KIA.KIAMenu();
                    case "honda":
                        return Honda.HondaMenu();
                    case "volvo":
                        return Volvo.VolvoMenu();
                    case "ford":
                        return Ford.FordMenu();
                }
            }
        }
        public static string Buing(decimal price)
        {
            while (true)
            {
                Client client = new Client();
                client.AccoutTop_up(price);
                client.Moneyaccount = client.TransAction(price);
                return "продано";
            }
        }
    }
}
