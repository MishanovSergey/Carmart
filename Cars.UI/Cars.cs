using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.UI
{
    class Cars //в ед числе car
    {
        private static readonly Random Availability = new Random(); //readonly
        public static string MainMenu()
        {
            Console.Clear();
            Console.Write($"$$$$$$$$$$$$$$$ |!|!| Магазин премиальных авто Twisted Metall: Fury Road |!|!| $$$$$$$$$$$$$$$ " +
                $"\n\n\nНиже представленны доступные бренды автомобилей:\n\n||Hyundai||\n||KIA||\n||Honda||\n||Volvo||\n||Ford||\n\nВведите желаемый бренд: ");
            while (true)
            {
                string brand = Console.ReadLine().ToLower();
                switch (brand)
                {
                    case "hyundai":
                        return "hyundai";
                    case "kia":
                        return "kia";
                    case "honda":
                        return "honda";
                    case "volvo":
                        return "volvo";
                    case "ford":
                        return "ford";
                    default:
                        {
                            Console.Write("Данный бренд не представлен в нашем салоне! Введите бренд из списка доступных: ");
                            break;
                        }
                }
            }
        }
        public static int Randomizer() //GetRandomValue or Randomize
        {
            return Availability.Next(0, 10);
        }
    }

    class Hyundai : Cars
    {
        private const decimal priceSolaris = 1459000.00M;
        private const decimal priceElantra = 1859000.00M;
        private const decimal priceSonata = 2159000.00M;
        private const decimal priceCreta = 2259000.00M;
        private const decimal priceTucson = 2659000.00M;
        private const decimal pricePalisade = 3259000.00M;

        private static readonly int availabilitySolaris = Randomizer();
        private static readonly int availabilityElantra = Randomizer();
        private static readonly int availabilitySonata = Randomizer();
        private static readonly int availabilityCreta = Randomizer();
        private static readonly int availabilityTucson = Randomizer();
        private static readonly int availabilityPalisade = Randomizer();

        private string specificationSolaris = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 1,6 литра;\nМощность:\t 123 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceSolaris}р.\n|Наличие|:\t |{availabilitySolaris}|шт.";
        private string specificationElantra = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,0 литра;\nМощность:\t 149 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceElantra}р.\n|Наличие|:\t |{availabilityElantra}|шт.";
        private string specificationSonata = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,5 литра;\nМощность:\t 188 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceSonata}р.\n|Наличие|:\t |{availabilitySonata}|шт.";
        private string specificationCreta = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,0 литра;\nМощность:\t 149 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceCreta}р.\n|Наличие|:\t |{availabilityCreta}|шт.";
        private string specificationTucson = $"Тип двигателя:\t Турбодизель;\nОбъем двигателя: 2,0 литра;\nМощность:\t 186 л/с;\nКоробка предач:\t 7-ти ступенчатая роботизированная;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceTucson}р.\n|Наличие|:\t |{availabilityTucson}|шт.";
        private string specificationPalisade = $"Тип двигателя:\t Турбодизель;\nОбъем двигателя: 2,2 литра;\nМощность:\t 199 л/с;\nКоробка предач:\t 7-ти ступенчатая роботизированная;\nКузов:\t\t Кроссовер;\nСтоимость:\t {pricePalisade}р.\n|Наличие|:\t |{availabilityPalisade}|шт.";

        public static decimal HyundaiMenu()
        {
            Hyundai hyundai = new Hyundai();
            Console.Clear();
            Console.Write($"Вы выбрали автомобили марки Hyundai. Модельный ряд этого бренда состоит из:" +
                $"\n\n||Solaris||\n{hyundai.specificationSolaris}" +
                $"\n\n||Elantra||\n{hyundai.specificationElantra}" +
                $"\n\n||Sonata||\n{hyundai.specificationSonata}" +
                $"\n\n||Creta||\n{hyundai.specificationCreta}" +
                $"\n\n||Tucson||\n{hyundai.specificationTucson}" +
                $"\n\n||Palisade||\n{hyundai.specificationPalisade}" +
                $"\n\nВведите интересующую вас модель, чтобы приобрести ее, или введите \"к меню\", чтобы попасть в главное меню: ");
            while (true)
            {
                string model = Console.ReadLine().ToLower();
                while (true)
                {
                    if (model == "solaris" && availabilitySolaris != 0)
                        return priceSolaris;
                    if (model == "elantra" && availabilityElantra != 0)
                        return priceElantra;
                    if (model == "sonata" && availabilitySonata != 0)
                        return priceSonata;
                    if (model == "creta" && availabilityCreta != 0)
                        return priceCreta;
                    if (model == "tucson" && availabilityTucson != 0)
                        return priceTucson;
                    if (model == "palisade" && availabilityPalisade != 0)
                        return pricePalisade;
                    if (model == "к меню")
                        return 0;
                    else
                    {
                        Console.Write("Такой модели нет в наличии или в модельном ряде выбранного вами бренда! Введите модель из списка доступных: ");
                        break;
                    }

                }
            }
        }

    }

    class KIA : Cars
    {
        private const decimal priceRio = 1459000.00M;
        private const decimal priceCeed = 1859000.00M;
        private const decimal priceK5 = 2159000.00M;
        private const decimal priceSportage = 2559000.00M;
        private const decimal priceSorento = 3259000.00M;
        private const decimal priceMohave = 3859000.00M;

        private static readonly int availabilityRio = Randomizer();
        private static readonly int availabilityCeed = Randomizer();
        private static readonly int availabilityK5 = Randomizer();
        private static readonly int availabilitySportage = Randomizer();
        private static readonly int availabilitySorento = Randomizer();
        private static readonly int availabilityMohave = Randomizer();

        private string specificationRio = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 1,6 литра;\nМощность:\t 123 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceRio}р.\n|Наличие|:\t |{availabilityRio}|шт.";
        private string specificationCeed = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,0 литра;\nМощность:\t 149 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Универсал;\nСтоимость:\t {priceCeed}р.\n|Наличие|:\t |{availabilityCeed}|шт.";
        private string specificationK5 = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,5 литра;\nМощность:\t 188 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceK5}р.\n|Наличие|:\t |{availabilityK5}|шт.";
        private string specificationSportage = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,0 литра;\nМощность:\t 149 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceSportage}р.\n|Наличие|:\t |{availabilitySportage}|шт.";
        private string specificationSorento = $"Тип двигателя:\t Турбодизель;\nОбъем двигателя: 2,0 литра;\nМощность:\t 186 л/с;\nКоробка предач:\t 7-ти ступенчатая роботизированная;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceSorento}р.\n|Наличие|:\t |{availabilitySorento}|шт.";
        private string specificationMohave = $"Тип двигателя:\t Турбодизель;\nОбъем двигателя: 2,2 литра;\nМощность:\t 199 л/с;\nКоробка предач:\t 7-ти ступенчатая роботизированная;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceMohave}р.\n|Наличие|:\t |{availabilityMohave}|шт.";

        public static decimal KIAMenu()
        {
            KIA kia = new KIA();
            Console.Clear();
            Console.Write($"Вы выбрали автомобили марки KIA. Модельный ряд этого бренда состоит из:" +
                $"\n\n||Rio||\n{kia.specificationRio}" +
                $"\n\n||Ceed||\n{kia.specificationCeed}" +
                $"\n\n||K5||\n{kia.specificationK5}" +
                $"\n\n||Sportage||\n{kia.specificationSportage}" +
                $"\n\n||Sorento||\n{kia.specificationSorento}" +
                $"\n\n||Mohave||\n{kia.specificationMohave}" +
                $"\n\nВведите интересующую вас модель, чтобы приобрести ее, или введите \"к меню\", чтобы попасть в главное меню: ");
            while (true)
            {
                string model = Console.ReadLine().ToLower();
                while (true)
                {
                    if (model == "rio" && availabilityRio != 0)
                        return priceRio;
                    if (model == "ceed" && availabilityCeed != 0)
                        return priceCeed;
                    if (model == "k5" && availabilityK5 != 0)
                        return priceK5;
                    if (model == "sportage" && availabilitySportage != 0)
                        return priceSportage;
                    if (model == "sorento" && availabilitySorento != 0)
                        return priceSorento;
                    if (model == "mohave" && availabilityMohave != 0)
                        return priceMohave;
                    if (model == "к меню")
                        return 0;
                    else
                    {
                        Console.Write("Такой модели нет в наличии или в модельном ряде выбранного вами бренда! Введите модель из списка доступных: ");
                        break;
                    }
                }
            }
        }
    }

    class Honda : Cars
    {
        private const decimal priceCivic = 1959000.00M;
        private const decimal priceAccord = 2559000.00M;
        private const decimal priceCRV = 3559000.00M;
        private const decimal pricePilot = 4359000.00M;

        private static readonly int availabilityCivic = Randomizer();
        private static readonly int availabilityAccord = Randomizer();
        private static readonly int availabilityCRV = Randomizer();
        private static readonly int availabilityPilot = Randomizer();

        private string specificationCivic = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,5 литра;\nМощность:\t 188 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Хэтчбэк;\nСтоимость:\t {priceCivic}р.\n|Наличие|:\t |{availabilityCivic}|шт.";
        private string specificationAccord = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,0 литра;\nМощность:\t 149 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceAccord}р.\n|Наличие|:\t |{availabilityAccord}|шт.";
        private string specificationCRV = $"Тип двигателя:\t Турбодизель;\nОбъем двигателя: 2,0 литра;\nМощность:\t 186 л/с;\nКоробка предач:\t 7-ти ступенчатая роботизированная;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceCRV}р.\n|Наличие|:\t |{availabilityCRV}|шт.";
        private string specificationPilot = $"Тип двигателя:\t Турбодизель;\nОбъем двигателя: 2,2 литра;\nМощность:\t 199 л/с;\nКоробка предач:\t 7-ти ступенчатая роботизированная;\nКузов:\t\t Кроссовер;\nСтоимость:\t {pricePilot}р.\n|Наличие|:\t |{availabilityPilot}|шт.";

        public static decimal HondaMenu()
        {
            Honda honda = new Honda();
            Console.Clear();
            Console.Write($"Вы выбрали автомобили марки Honda. Модельный ряд этого бренда состоит из:" +
                $"\n\n||Civic||\n{honda.specificationCivic}" +
                $"\n\n||Accord||\n{honda.specificationAccord}" +
                $"\n\n||CRV||\n{honda.specificationCRV}" +
                $"\n\n||Pilot||\n{honda.specificationPilot}" +
                $"\n\nВведите интересующую вас модель, чтобы приобрести ее, или введите \"к меню\", чтобы попасть в главное меню: ");
            while (true)
            {
                string model = Console.ReadLine().ToLower();
                while (true)
                {
                    if (model == "civic" && availabilityCivic != 0)
                        return priceCivic;
                    if (model == "accord" && availabilityAccord != 0)
                        return priceAccord;
                    if (model == "CRV" && availabilityCRV != 0)
                        return priceCRV;
                    if (model == "pilot" && availabilityPilot != 0)
                        return pricePilot;
                    if (model == "к меню")
                        return 0;
                    else
                    {
                        Console.Write("Такой модели нет в наличии или в модельном ряде выбранного вами бренда! Введите модель из списка доступных: ");
                        break;
                    }
                }
            }
        }
    }

    class Volvo : Cars
    {
        private const decimal priceS60 = 3259000.00M;
        private const decimal priceS90 = 3959000.00M;
        private const decimal priceXC40 = 3659000.00M;
        private const decimal priceXC60 = 4259000.00M;
        private const decimal priceXC90 = 4859000.00M;

        private static readonly int availabilityS60 = Randomizer();
        private static readonly int availabilityS90 = Randomizer();
        private static readonly int availabilityXC40 = Randomizer();
        private static readonly int availabilityXC60 = Randomizer();
        private static readonly int availabilityXC90 = Randomizer();

        private string specificationS60 = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,0 литра;\nМощность:\t 149 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceS60}р.\n|Наличие|:\t |{availabilityS60}|шт.";
        private string specificationS90 = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,5 литра;\nМощность:\t 188 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceS90}р.\n|Наличие|:\t |{availabilityS90}|шт.";
        private string specificationXC40 = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,0 литра;\nМощность:\t 149 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceXC40}р.\n|Наличие|:\t |{availabilityXC40}|шт.";
        private string specificationXC60 = $"Тип двигателя:\t Турбодизель;\nОбъем двигателя: 2,0 литра;\nМощность:\t 186 л/с;\nКоробка предач:\t 7-ти ступенчатая роботизированная;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceXC60}р.\n|Наличие|:\t |{availabilityXC60}|шт.";
        private string specificationXC90 = $"Тип двигателя:\t Турбодизель;\nОбъем двигателя: 2,2 литра;\nМощность:\t 199 л/с;\nКоробка предач:\t 7-ти ступенчатая роботизированная;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceXC90}р.\n|Наличие|:\t |{availabilityXC90}|шт.";

        public static decimal VolvoMenu()
        {
            Volvo volvo = new Volvo();
            Console.Clear();
            Console.Write($"Вы выбрали автомобили марки Volvo. Модельный ряд этого бренда состоит из:" +
                $"\n\n||S60||\n{volvo.specificationS60}" +
                $"\n\n||S90||\n{volvo.specificationS90}" +
                $"\n\n||XC40||\n{volvo.specificationXC40}" +
                $"\n\n||XC60||\n{volvo.specificationXC60}" +
                $"\n\n||XC90||\n{volvo.specificationXC90}" +
                $"\n\nВведите интересующую вас модель, чтобы приобрести ее, или введите \"к меню\", чтобы попасть в главное меню: ");
            while (true)
            {
                string model = Console.ReadLine().ToLower();
                while (true)
                {
                    if (model == "s60" && availabilityS60 != 0)
                        return priceS60;
                    if (model == "s90" && availabilityS90 != 0)
                        return priceS90;
                    if (model == "xc40" && availabilityXC40 != 0)
                        return priceXC40;
                    if (model == "xc60" && availabilityXC60 != 0)
                        return priceXC60;
                    if (model == "xc90" && availabilityXC40 != 0)
                        return priceXC90;
                    if (model == "к меню")
                        return 0;
                    else
                    {
                        Console.Write("Такой модели нет в наличии или в модельном ряде выбранного вами бренда! Введите модель из списка доступных: ");
                        break;
                    }
                }
            }
        }

    }

    class Ford : Cars
    {
        private const decimal priceFiesta = 1459000.00M;
        private const decimal priceFocus = 1859000.00M;
        private const decimal priceMondeo = 2159000.00M;
        private const decimal priceEcosport = 2259000.00M;
        private const decimal priceKuga = 2659000.00M;
        private const decimal priceExplorer = 3259000.00M;

        private static readonly int availabilityFiesta = Randomizer();
        private static readonly int availabilityFocus = Randomizer();
        private static readonly int availabilityMondeo = Randomizer();
        private static readonly int availabilityEcosport = Randomizer();
        private static readonly int availabilityKuga = Randomizer();
        private static readonly int availabilityExplorer = Randomizer();

        private string specificationFiesta = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 1,6 литра;\nМощность:\t 123 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceFiesta}р.\n|Наличие|:\t |{availabilityFiesta}|шт.";
        private string specificationFocus = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,0 литра;\nМощность:\t 149 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceFocus}р.\n|Наличие|:\t |{availabilityFocus}|шт.";
        private string specificationMondeo = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,5 литра;\nМощность:\t 188 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Седан;\nСтоимость:\t {priceMondeo}р.\n|Наличие|:\t |{availabilityMondeo}|шт.";
        private string specificationEcosport = $"Тип двигателя:\t Бензин;\nОбъем двигателя: 2,0 литра;\nМощность:\t 149 л/с;\nКоробка предач:\t 6-ти ступенчатый классический автомат;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceEcosport}р.\n|Наличие|:\t |{availabilityEcosport}|шт.";
        private string specificationKuga = $"Тип двигателя:\t Турбодизель;\nОбъем двигателя: 2,0 литра;\nМощность:\t 186 л/с;\nКоробка предач:\t 7-ти ступенчатая роботизированная;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceKuga}р.\n|Наличие|:\t |{availabilityKuga}|шт.";
        private string specificationExplorer = $"Тип двигателя:\t Турбодизель;\nОбъем двигателя: 2,2 литра;\nМощность:\t 199 л/с;\nКоробка предач:\t 7-ти ступенчатая роботизированная;\nКузов:\t\t Кроссовер;\nСтоимость:\t {priceExplorer}р.\n|Наличие|:\t |{availabilityExplorer}|шт.";

        public static decimal FordMenu()
        {
            Ford ford = new Ford();
            Console.Clear();
            Console.Write($"Вы выбрали автомобили марки Ford. Модельный ряд этого бренда состоит из:" +
                $"\n\n||Fiesta||\n{ford.specificationFiesta}" +
                $"\n\n||Focus||\n{ford.specificationFocus}" +
                $"\n\n||Mondeo||\n{ford.specificationMondeo}" +
                $"\n\n||Ecosport||\n{ford.specificationEcosport}" +
                $"\n\n||Kuga||\n{ford.specificationKuga}" +
                $"\n\n||Explorer||\n{ford.specificationExplorer}" +
                $"\n\nВведите интересующую вас модель, чтобы приобрести ее, или введите \"к меню\", чтобы попасть в главное меню: ");
            while (true)
            {
                string model = Console.ReadLine().ToLower();
                while (true)
                {
                    if (model == "fiesta" && availabilityFiesta != 0)
                        return priceFiesta;
                    if (model == "focus" && availabilityFocus != 0)
                        return priceFocus;
                    if (model == "mondeo" && availabilityMondeo != 0)
                        return priceMondeo;
                    if (model == "ecosport" && availabilityEcosport != 0)
                        return priceEcosport;
                    if (model == "kuga" && availabilityKuga != 0)
                        return priceKuga;
                    if (model == "explorer" && availabilityExplorer != 0)
                        return priceExplorer;
                    if (model == "к меню")
                        return 0;
                    else
                    {
                        Console.Write("Такой модели нет в наличии или в модельном ряде выбранного вами бренда! Введите модель из списка доступных: ");
                        break;
                    }
                }
            }
        }
    }
}
