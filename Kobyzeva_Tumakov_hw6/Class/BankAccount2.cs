using Kobyzeva_Tumakov_hw6.Enum;

namespace Kobyzeva_Tumakov_hw6
{
    /// <summary>
    /// Банковский счет с генерацией номера
    /// </summary>
    public class BankAccount2
    {
        private decimal balance;
        private AccountType accountType;
        private static ulong accountNumberInf = 0;
        private string accountNumber;
        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }
        public AccountType AccountTypeC
        {
            get { return accountType; }
            set { accountType = value; }
        }

        /// <summary>
        /// Инициализирует новый экземпляр класса и генерирует номер счета.
        /// </summary>
        /// <param name="balanceUser">Начальный баланс.</param>
        /// <param name="typeAccountUser">Тип счета.</param>
        public BankAccount2(decimal balanceUser, AccountType typeAccountUser)
        {
            accountNumberInf++;
            accountNumber = accountNumberInf.ToString("D20");
            Balance = balanceUser;
            AccountTypeC = typeAccountUser;
        }

        /// <summary>
        /// Выводит информацию о банковском счете в консоль
        /// </summary>
        public void PrintOnConsole()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}\nБаланс: {Balance}\nТип счета: {AccountTypeC}");
        }
    }
}