namespace Kobyzeva_Latypova_hw6.Классы
{
    public abstract class Brewery
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Composition { get; set; }

        public Brewery(string name, decimal price, string composition)
        {
            ProductName = name;
            Price = price;
            Composition = composition;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Id - {Id} Название: {ProductName}, Цена: {Price} руб.");
            Console.WriteLine($"Состав: {Composition}");
        }

        public abstract void CheckQuality();

        public abstract byte CalculateExciseTax();

        public void ChangePrice(decimal newPrice)
        {
            if (newPrice > 0)
            {
                Price = newPrice;
                Console.WriteLine($"Цена изменена, текущее значение: {Price} руб.");
            }
            else { Console.WriteLine($"Ошибка! Цена не была изменена, текцщая цена: {Price} руб."); }
        }
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
