using Kobyzeva_Tumakov_hw6.Enum;

namespace Kobyzeva_Tumakov_hw6
{
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
        public BankAccount(string accountNumberUser, decimal balanceUser, AccountType typeAccountUser)
        {
            AccountNumber = accountNumberUser;
            Balance = balanceUser;
            AccountTypeC = typeAccountUser;
        }
        public void PrintOnConsole()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}\nБаланс: {Balance}\nТип счета: {AccountTypeC}");
        }
    }
}