using Kobyzeva_Tumakov_hw6.Enum;

namespace Kobyzeva_Tumakov_hw6
{
    /// <summary>
    /// Банковский счет с методами пополнения и снятия средств
    /// </summary>
    public class BankAccount3
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
        /// Инициализирует экземпляр класса с автоматической генерацией номера
        /// </summary>
        /// <param name="balanceUser">Начальный баланс.</param>
        /// <param name="typeAccountUser">Тип счета.</param>
        public BankAccount3(decimal balanceUser, AccountType typeAccountUser)
        {
            accountNumberInf++;
            accountNumber = accountNumberInf.ToString("D20");
            Balance = balanceUser;
            AccountTypeC = typeAccountUser;
        }

        /// <summary>
        /// Выводит информацию о счете в консоль
        /// </summary>
        public void PrintOnConsole()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}\nБаланс: {Balance}\nТип счета: {AccountTypeC}");
        }

        /// <summary>
        /// Пополнение баланса
        /// </summary>
        /// <param name="sum">Сумма для пополнения.</param>
        public bool Deposit(decimal sum)
        {
            try
                {
                Balance += sum;
                return true;
                }
            catch {  return false; }
        }

        /// <summary>
        /// Снятие средств
        /// </summary>
        /// <param name="sum">Сумма для снятия</param>
        public bool Withdrawal(decimal sum)
        {
            try
            {
                if ((Balance - sum) < 0)
                {
                    return false;
                }
                else
                {
                    Balance -= sum;
                    return true;
                }
            }
            catch { return false; }
        }
    }
}