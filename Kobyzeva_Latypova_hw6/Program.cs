using Kobyzeva_Latypova_hw6.Классы;

namespace Kobyzeva_Latypova_hw6
{
    internal class Program
    {
        static bool ActionWithALco(AlcoholicBeerBrewery Beer)
        {
            bool flag = true;
            while(flag)
            {
                Console.WriteLine("Выберите номер действия:\n1 - Вывести текущие данные\n2 - Расчитать аксцизу\n3 - Изменить цену\n4 - Изменить состав" +
                    "\n5 - Проверка данных\n6 - Сгенерировать отчет\n7 - Выполнить экспертизу\n8 - Выйти\n9 - начать заново (с введения данных о пиве при этом текущие данные будут потеряны)");
                int.TryParse(Console.ReadLine(), out int action);
                switch (action)
                {
                    case 1:
                        Beer.PrintInfo();
                        break;

                    case 2:
                        Beer.CalculateExciseTax();
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("Введите цену, на которую хотите сменить");
                            decimal.TryParse(Console.ReadLine(), out decimal newPrice);
                            Beer.ChangePrice(newPrice);
                        }
                        catch { Console.WriteLine("Введено не корректное число"); }
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("Введите состав, на который хотите сменить");
                            string newComposition = Console.ReadLine();
                            Beer.ChangeComposition(newComposition);
                        }
                        catch { Console.WriteLine("Произошла ошибка"); }
                        break;

                    case 5:
                        Beer.CheckQuality();
                        break;

                    case 6:
                        Beer.GenerateTaxReport();
                        break;

                    case 7:
                        Beer.CheckAlcoholContent();
                        break;

                    case 8:
                        return false;

                    case 9:
                        return true;

                    default:
                        Console.WriteLine("Не удалось распознать номер команды, попробуйте еще раз");
                        break;
                }
            }
            return true;
        }

        static bool ActionWithNonALco(NonAlcoholicBeerBrewery Beer)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Выберите номер действия:\n1 - Вывести текущие данные\n2 - Расчитать аксцизу\n3 - Изменить цену\n4 - Изменить состав" +
                    "\n5 - Проверка данных\n6 - Сгенерировать декларацию\n7 - Выполнить экспертизу\n8 - Выйти\n9 - начать заново (с введения данных о пиве при этом текущие данные будут потеряны)");
                bool isParseAction = int.TryParse(Console.ReadLine(), out int action);
                switch (action)
                {
                    case 1:
                        Beer.PrintInfo();
                        break;

                    case 2:
                        Beer.CalculateExciseTax();
                        break;

                    case 3:
                        try
                        {
                            Console.WriteLine("Введите цену, на которую хотите сменить");
                            decimal.TryParse(Console.ReadLine(), out decimal newPrice);
                            Beer.ChangePrice(newPrice);
                        }
                        catch { Console.WriteLine("Введено не корректное число"); }
                        break;

                    case 4:
                        try
                        {
                            Console.WriteLine("Введите состав, на который хотите сменить");
                            string newComposition = Console.ReadLine();
                            Beer.ChangeComposition(newComposition);
                        }
                        catch { Console.WriteLine("Произошла ошибка"); }
                        break;

                    case 5:
                        Beer.CheckQuality();
                        break;

                    case 6:
                        Beer.DeclarationPreparation();
                        break;

                    case 7:
                        Beer.CheckResidualAlcohol();
                        break;

                    case 8:
                        return false;

                    case 9:
                        return true;

                    default:
                        Console.WriteLine("Не удалось распознать номер команды, попробуйте еще раз");
                        break;
                }
            }
            return true;
        }
        static void Task1()
        {
            Console.WriteLine("Задание 1. Тема - Пивоварня");

            bool isRestart = true;
            while(isRestart)
            {
                Console.WriteLine("Введите данные о пиве");
                string[] types = new string[] { "БезАлко", "Алко" };
                Console.Write("Тип пива (скопируйте: БезАлко / Алко): ");
                string type = Console.ReadLine();
                Console.Write("Имя продукта: ");
                string name = Console.ReadLine();
                Console.Write("Цена: ");
                bool isParsePrice = decimal.TryParse(Console.ReadLine(), out decimal price);
                Console.Write("Состав: ");
                string composition = Console.ReadLine();

                bool flag = true;
                while(flag)
                {
                    if (type == "Алко" && isParsePrice && price > 0)
                    {
                        Console.Write("Процент спирта: ");
                        bool isParsePers = float.TryParse(Console.ReadLine(), out float alcoPercentage);
                        if (isParsePers && alcoPercentage < 100 && alcoPercentage > 0)
                        {
                            try
                            {
                                var Beer = new AlcoholicBeerBrewery(name, price, composition, alcoPercentage);
                                isRestart = ActionWithALco(Beer);
                                flag = false;
                            }
                            catch { Console.WriteLine("Выполнить действие не удалось, возникла ошибка"); }
                        }
                        else { Console.WriteLine("Неверно введен процент спирта, попробуйте заново"); }
                    }
                    else if (type == "БезАлко" && isParsePrice && price > 0)
                    {
                        Console.Write("Количество сахара (гр / литр): ");
                        bool isParseSugar = float.TryParse(Console.ReadLine(), out float sugar);
                        if (isParseSugar && sugar >= 0)
                        {
                            try
                            {
                                var Beer = new NonAlcoholicBeerBrewery(name, price, composition, sugar);
                                isRestart = ActionWithNonALco(Beer);
                                flag = false;
                            }
                            catch { Console.WriteLine("Выполнить действие не удалось, возникла ошибка"); }
                        }
                        else { Console.WriteLine("Неверно введено количество сахара, попробуйте заново"); }
                    }
                    else 
                    { 
                        Console.WriteLine("Неверно введена цена или тип пива, попробуйте заново");
                        flag = false;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Task1();
        }
    }
}
