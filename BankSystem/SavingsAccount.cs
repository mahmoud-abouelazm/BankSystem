using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public class SavingAccount : BankAccount , IInterestEarning
    {
        private decimal _persent = 0.03m;
        public SavingAccount(string accountHolderName , decimal balance) : base(AccountType.SAV, accountHolderName , balance)
        {
        }

        public void ApplyInterest(decimal amount , int monthes)
        {
            Balance += amount;
            Console.WriteLine($"Total interest earned in {monthes} months: {amount:C}");
        }

        public decimal CalculateInterest()
        {
            return _persent * Balance;
        }
    }
}
