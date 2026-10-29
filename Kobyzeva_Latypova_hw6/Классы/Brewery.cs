namespace Kobyzeva_Latypova_hw6.Классы
{
    /// <summary>
    /// Абстрактный базовый класс, представляющий пивоваренный продукт
    /// </summary>
    public abstract class Brewery
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Composition { get; set; }

        /// <summary>
        /// Инициализация экземпляр класса
        /// </summary>
        /// <param name="name">Название</param>
        /// <param name="price">Цена</param>
        /// <param name="composition">Состав</param>
        public Brewery(string name, decimal price, string composition)
        {
            ProductName = name;
            Price = price;
            Composition = composition;
        }

        /// <summary>
        /// Вывод информации о продукте в консоль
        /// </summary>
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Id - {Id} Название: {ProductName}, Цена: {Price} руб.");
            Console.WriteLine($"Состав: {Composition}");
        }

        /// <summary>
        /// Выполнение проверки качества
        /// </summary>
        public abstract void CheckQuality();

        /// <summary>
        /// Рассчет суммы акцизы
        /// </summary>
        public abstract byte CalculateExciseTax();

        /// <summary>
        /// Изменение цены
        /// </summary>
        public void ChangePrice(decimal newPrice)
        {
            if (newPrice > 0)
            {
                Price = newPrice;
                Console.WriteLine($"Цена изменена, текущее значение: {Price} руб.");
            }
            else { Console.WriteLine($"Ошибка! Цена не была изменена, текцщая цена: {Price} руб."); }
        }

        /// <summary>
        /// Изменение состава продукта
        /// </summary>
        public void ChangeComposition(string newComposition)
        {
            if (newComposition.Length > 0)
            {
                Console.WriteLine($"Изменения внесены");
                Composition = newComposition;
            }
            else { Console.WriteLine($"Ошибка! Изменения НЕ внесены"); }
        }


    }
}
