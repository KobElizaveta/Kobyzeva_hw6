using Kobyzeva_Tumakov_hw6.Enum;

namespace Kobyzeva_Tumakov_hw6
{
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
        public BankAccount3(decimal balanceUser, AccountType typeAccountUser)
        {
            accountNumberInf++;
            accountNumber = accountNumberInf.ToString("D20");
            Balance = balanceUser;
            AccountTypeC = typeAccountUser;
        }
        public void PrintOnConsole()
        {
            Console.WriteLine($"Номер счета: {AccountNumber}\nБаланс: {Balance}\nТип счета: {AccountTypeC}");
        }

        public bool Deposit(decimal sum)
        {
            try
                {
                Balance += sum;
                return true;
                }
            catch {  return false; }
        }

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