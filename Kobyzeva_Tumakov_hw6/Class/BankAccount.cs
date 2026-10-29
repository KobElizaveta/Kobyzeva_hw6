using Kobyzeva_Tumakov_hw6.Enum;

namespace Kobyzeva_Tumakov_hw6
{
    /// <summary>
    /// Банковский счета с рвводом номера через консоль
    /// </summary>
    public class BankAccount
    {
        private string accountNumber;
        private decimal balance;
        private AccountType accountType;

        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
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
        /// Инициализирует новый экземпляр класса
        /// </summary>
        /// <param name="accountNumberUser">Номер счета.</param>
        /// <param name="balanceUser">Баланс.</param>
        /// <param name="typeAccountUser">Тип счета</param>
        public BankAccount(string accountNumberUser, decimal balanceUser, AccountType typeAccountUser)
        {
            AccountNumber = accountNumberUser;
            Balance = balanceUser;
            AccountTypeC = typeAccountUser;
        }

        /// <summary>
        /// Вывод информации о банковском счете в консоль
        /// </summary>
        public void PrintOnConsole()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}\nБаланс: {Balance}\nТип счета: {AccountTypeC}");
        }
    }
}