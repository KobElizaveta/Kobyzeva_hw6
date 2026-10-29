using Kobyzeva_Tumakov_hw6.Class;
using Kobyzeva_Tumakov_hw6.Enum;

namespace Kobyzeva_Tumakov_hw6
{
    internal class Program
    {
        static void Task7_1()
        {
            Console.WriteLine("Упражнение 7.1");
            Console.WriteLine("Введите данные банковского счета:");
            bool flag71 = true;
            while (flag71)
            {
                Console.Write("Номер счета: ");
                string number = Console.ReadLine();
                Console.Write("Баланс счета: ");
                bool isParseBalance = decimal.TryParse(Console.ReadLine(), out decimal balance);
                Console.Write("Тип счета: ");
                bool isParseTypeAcc = AccountType.TryParse(Console.ReadLine(), out AccountType accountType);
                if (!isParseBalance | !isParseTypeAcc | !number.All(char.IsDigit) | number.Length != 20)
                {
                    Console.WriteLine("Неверно введены данные, попробуйте заново");
                }
                else
                {
                    try
                    {
                        BankAccount NewAccount = new BankAccount(number, balance, accountType);
                        Console.WriteLine("Данные добавлены. Ваши данные:");
                        NewAccount.PrintOnConsole();
                        flag71 = false;
                    }
                    catch 
                    {
                        Console.WriteLine("Возникла ошибка. Данные не добавлены. Попробуйте заново, проверьте корреткность данных");
                    }
                }
            }
        }
        
        static BankAccount2 EnterInfo()
        {
            Console.WriteLine("Введите данные банковского счета:");
            bool flag = true;
            while (flag)
            {
                Console.Write("Баланс счета: ");
                bool isParseBalance = decimal.TryParse(Console.ReadLine(), out decimal balance);
                Console.Write("Тип счета: ");
                bool isParseTypeAcc = AccountType.TryParse(Console.ReadLine(), out AccountType accountType);
                if (!isParseBalance | !isParseTypeAcc)
                {
                    Console.WriteLine("Неверно введены данные, попробуйте заново");
                }
                else
                {
                    try
                    {
                        BankAccount2 NewAccount = new BankAccount2(balance, accountType);
                        Console.WriteLine("Данные добавлены. Ваши данные:");
                        return NewAccount;
                    }
                    catch
                    {
                        Console.WriteLine("Возникла ошибка. Данные не добавлены.");
                    }
                }
            }
            return null;
        }
        static void Task7_2()
        {
            Console.WriteLine("Упражнение 7.2");
            bool flag = true;
            while(flag)
            {
                BankAccount2 Account = EnterInfo();
                Account.PrintOnConsole();
                Console.Write("Хотите продолжить? (д/н)");
                if (Console.ReadLine() == "н") 
                {
                    flag = false; 
                }
            }
        }

        static void Task7_3()
        {
            Console.WriteLine("Упражнение 7.3");
            Console.WriteLine("Давайте создадим аккаунт");
            bool flag = true;
            BankAccount3 NewAccount = null;
            while (flag)
            {
                Console.Write("Баланс счета: ");
                bool isParseBalance = decimal.TryParse(Console.ReadLine(), out decimal balance);
                Console.Write("Тип счета: ");
                bool isParseTypeAcc = AccountType.TryParse(Console.ReadLine(), out AccountType accountType);
                if (!isParseBalance | !isParseTypeAcc)
                {
                    Console.WriteLine("Неверно введены данные, попробуйте заново");
                }
                else
                {
                    try
                    {
                        NewAccount = new BankAccount3(balance, accountType);
                        Console.WriteLine("Данные добавлены.");
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("Возникла ошибка. Данные не добавлены.");
                    }
                }
            }

            bool flagIsContinue = true;
            while (flagIsContinue)
            {
                Console.Write("Выберите действие с аккаунтом ('снять'/'положить'): ");
                string action = Console.ReadLine();
                if (action == "снять" | action == "положить")
                {
                    Console.Write("Введите сумму: ");
                    if (!decimal.TryParse(Console.ReadLine(), out decimal sum))
                    {
                        Console.WriteLine("Неверно введены данные, попробуйте заново");
                    }

                    else if (action == "снять")
                    {
                        if (NewAccount.Withdrawal(sum)) 
                        { 
                            Console.WriteLine($"Средства со счета сняты, текущий счет: {NewAccount.Balance}");
                            flagIsContinue = false;
                        }
                        else 
                        { 
                            Console.WriteLine("Возникла ошибка. Дейсвтие не было выполнено"); 
                        }
                    }
                    else if (action == "положить")
                    {
                        if (NewAccount.Deposit(sum)) 
                        { 
                            Console.WriteLine($"Средства  внесены на счет, текущий счет: {NewAccount.Balance}");
                            flagIsContinue = false;
                        }
                        else 
                        { 
                            Console.WriteLine("Возникла ошибка. Дейсвтие не было выполнено"); 
                        }
                    }
                }
                else 
                {
                    Console.WriteLine("Неверно введы данные");
                }
            }
            {
                
            }

        }

        static void TaskHW()
        {
            Console.WriteLine("Домашнее задание 7.1");
            Console.WriteLine("Введите данные о здании");

            bool flag = true;
            Building newHouse = null;
            while (flag)
            {
                Console.Write("Введите высоту здания: ");
                bool isParseHigh = float.TryParse(Console.ReadLine(), out float high);
                Console.Write("Введите количество этажей: ");
                bool isParseFloors = byte.TryParse(Console.ReadLine(), out byte floors);
                Console.Write("Введите количество квартир: ");
                bool isParseApartam = int.TryParse(Console.ReadLine(), out int apartaments);
                Console.Write("Введите количество подъездов: ");
                bool isParseEntrances = byte.TryParse(Console.ReadLine(), out byte entrances);

                if (!isParseHigh | !isParseFloors | !isParseApartam | !isParseEntrances)
                {
                    Console.WriteLine("Ошибка при введении данных, попробуйте заново");
                }
                else
                {
                    try
                    {
                        newHouse = new Building(high, floors, apartaments, entrances);
                        Console.WriteLine($"Здвние добавлено. Полная информация:");
                        newHouse.PrintOnConsole();
                        flag = false;
                    }
                    catch
                    {
                        Console.WriteLine("ВОзникла ошибка. Здание не создано");
                    }
                }
            }

            flag = true;
            while(flag)
            {
                Console.WriteLine("Вы можете узнать информацию о здании. Введите номер команды:\n" +
                    "1 - высота этажа; 2 - количесвто квартир в подъезде; 3 - количество квартир на этаже;\n " +
                    "4 - количесвто квартир на лестничной площадке, 5 - если хотите завершить");
                if(!byte.TryParse(Console.ReadLine(), out byte actionNum) | actionNum < 1 | actionNum > 5)
                {
                    Console.WriteLine("Неверный ввод номера команды");
                }

                else if (actionNum == 1)
                {
                    Console.WriteLine($"Примерная высота этажа: {newHouse.FLoorHeight()}");
                }
                else if (actionNum == 2)
                {
                    Console.WriteLine($"Среднее количесвто квартир в подъезде: {newHouse.AppartamentsPerEntrance()}");
                }
                else if (actionNum == 3)
                {
                    Console.WriteLine($"Среднее количество квартир на этаже: {newHouse.ApartamentsPerFloor()}");
                }
                else if (actionNum == 4)
                {
                    Console.WriteLine($"Среднее количество квартир на лестнично площадке: {newHouse.AppartamentsPerLanding()}");
                }
                else { flag = false; }
            }
        }
        static void Main(string[] args)
        {
            Task7_1();
            Task7_2();
            Task7_3();
            
            TaskHW();
        }
    }
}
