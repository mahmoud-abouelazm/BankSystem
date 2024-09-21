using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class InvestmentAccount : BankAccount
    {
        private decimal _persent = 0.05m;
        public InvestmentAccount(string accountHolderName , decimal balance) : base(AccountType.INV, accountHolderName , balance)
        {
        }
        public void ApplyInterest(decimal amount, int monthes)
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
