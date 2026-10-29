namespace Kobyzeva_Latypova_hw6.Классы
{
    public class AlcoholicBeerBrewery : Brewery
    {
        public double AlcoholPercentage { get; set; }

        public AlcoholicBeerBrewery() : base("Алкогольное пиво", 0, "Неизвестно")
        {
            AlcoholPercentage = 0;
        }
        public AlcoholicBeerBrewery(string name, decimal price, string composition, float alcoholPercentage)
            : base(name, price, composition)
        {
            AlcoholPercentage = alcoholPercentage;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Тип: Алкогольное, крепость: {AlcoholPercentage}%");
        }

        public override void CheckQuality()
        {
            if (AlcoholPercentage > 0 && AlcoholPercentage < 20)
            {
                Console.WriteLine($"Проверка продукта: {ProductName}, крепость: {AlcoholPercentage}% в норме.");
            }
            else
            {
                Console.WriteLine($"Проверка '{ProductName}': много спирта!");
            }
        }

        public override byte CalculateExciseTax()
        {
            byte Excise = 0;
            if (0.5 < AlcoholPercentage && AlcoholPercentage < 8.6)
            {
                Excise = 33;
            }
            else if (AlcoholPercentage >= 8.6)
            {
                Excise = 41;
            }
            Console.WriteLine($"Аксциза = {Excise} за литр");
            return Excise;
        }

        public void GenerateTaxReport()
        {
            string TextTaxReport = "Форма №6767 (Утверждена Министерством Хмеля и Солода)\nОтчет о производстве и обороте алкогольной продукции, а также об исчезновении пива по необъяснимым причинам" +
                " за период с 01.01.2025 по 01.01.2026\n1.Сведения о налогоплательщике:\nНаименование организации: ООО Лиза-алкоголик\nИНН: 7777777777777777\nЮридический адрес: г.Казань, ул.Деревня Универсиады, д.3" +
                "\nФактический адрес: там же, только с другой стороны забора\nОсновной вид деятельности: ПРоизводство жидкости, повышающей настроение(и понижающей завтрашнее самочувствие)" +
                "\nГлавный бухгалтер: Плюшевая Собачка\n\n2.Сведения о продукте: (об этом история умалчивает...)\n\n3.Расчет суммы акциза и налогов: а кто такие фиксики - большой большой секрет...)" +
                "\n\n4.Приложения к отчету:\n1.Копия лицензии на право производства (была заплонирована, но размокла от пива)\n2.Акт списания 10 литров 'на дигустацию' (подписан тремя свидетелями)\n\n" +
                "Руководитель организации: Кобызева Елизавета группа 09-621\nГлавный бухгалтер: (просил не будить)";
            Console.WriteLine(TextTaxReport);
        }

        public void CheckAlcoholContent()
        {
            Random random = new Random();

            float percentage = (float)Math.Round(random.NextDouble(), 2);
            if (random.Next(2) % 2 == 0)
            {
                Console.WriteLine($"Результат экспертизы:{AlcoholPercentage - percentage:F2}% при указанном значении - {AlcoholPercentage}");
            }
            else
            {
                Console.WriteLine($"Результат экспертизы:{AlcoholPercentage + percentage:F2}% при указанном значении - {AlcoholPercentage}");
            }

        }
    }
}
