namespace Kobyzeva_Latypova_hw6.Классы
{
    /// <summary>
    /// Создание объекта безалкогольного пива; методы с данным объектом
    /// </summary>
    public class NonAlcoholicBeerBrewery : Brewery
    {
        public double SugarContent { get; set; }

        /// <summary>
        /// Инициализация базового экземпляра класса
        /// </summary>
        public NonAlcoholicBeerBrewery() : base("Безалкогольное пиво", 0, "Неизвестно")
        {
            SugarContent = 0;
        }

        /// <summary>
        /// Инициализация экземпляра класса
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="price">Цена</param>
        /// <param name="composition">Состав</param>
        /// <param name="sugar">Содержание сахара</param>
        public NonAlcoholicBeerBrewery(string name, decimal price, string composition, float sugar)
            : base(name, price, composition)
        {
            SugarContent = sugar;
        }

        /// <summary>
        /// Вывод информации
        /// </summary>
        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine($"Тип: Безалкогольное, сахар: {SugarContent} гр/литр");
        }

        /// <summary>
        /// Проверка качества по содержанию сахара
        /// </summary>
        public override void CheckQuality()
        {
            if (SugarContent < 5)
                Console.WriteLine($"Проверка '{ProductName}': Сахар в норме.");
            else
                Console.WriteLine($"Проверка '{ProductName}': Много сахара!");
        }

        /// <summary>
        /// Рассчет суммы акциза
        /// </summary>
        public override byte CalculateExciseTax()
        {
            Console.WriteLine("0 рублей за литр");
            return 0;
        }

        /// <summary>
        /// Выполнение экспертизы на содержание алкоголя 
        /// </summary>
        public void CheckResidualAlcohol()
        {
            Random random = new Random();
            double resultCheck = Math.Round(random.NextDouble(), 2);
            if (resultCheck <= 0.5)
            {
                Console.WriteLine($"Результат экспертизы: {resultCheck:F2}% - допустимое значение");
            }
            else
            {
                Console.WriteLine($"Результат экспертизы: {resultCheck:F2}% - НЕ допустимое значение");
            }
        }

        /// <summary>
        /// Генерирация и вывод декларацию
        /// </summary>
        public void DeclarationPreparation()
        {
            Console.WriteLine($"ДЕКЛАРАЦИЯ О СООТВЕТСТВИИ\nТехническому регламенту 'О безопасности жидких разочарований'\n\n" +
                $"1.Наименование продукта: '{ProductName}'\n\n2.Заявитель и Изготовитель:\nООО 'Лиза-безалкоголик'\nЮридический адрес: г.Казань, ул.Деревня Универсиады, д.3" +
                $"\n\n3.Продукция соответствует следующим нормативным документам:\n - ГОСТ Р0б0-2026 'Имитация бурного веселья в компании пьющих друзей'\n - ТУ 4022-001 " +
                $"'Вкус предательства, хлебной корки и экзистенциального кризиса'\n - СанПин 2.2.2.4 'Об отсутствия похмелья, на наличии вздутия живота, эквивалентного проглоченному азбузу'" +
                $"\n\n4. Протокол испытаний №12-Н-ТРЕЗВ от 07.12.2026 г.\nИспытательная лаборатория: ФГБУ 'Плюшевый Пёсик'\n . . \nВсё в норме в общем\n\n5.Особые условия и ограничения применения:" +
                $"\nКатегорически не рекомендуется не рекомендуется употреблять в одиночестве перед теливизором во время трансляции спортивных матчей. Вызывает чувство глубокой несправедливости бытия." +
                $"\n\nЗаявитель:\n_______/Кобызева Е.Е (главный сомелье)");
        }
    }
}
