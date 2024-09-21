using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    internal class CreditAccount:BankAccount
    {
        public CreditAccount(string accountHolderName , decimal balance ,decimal limit) : base(AccountType.CRA, accountHolderName , balance)
        {
            CreditLimit = limit;
        
        }
        protected decimal CreditLimit;
        public override bool Withdraw(decimal amount)
        {
            if(amount <=0) { return false; }
            if(amount > Balance)
            {
                if(amount <= Balance + CreditLimit)
                {
                    CreditLimit -= (amount - Balance);
                    Balance = 0;
                }
                else
                {
                    throw new ArgumentException("Error limit exceded");
                }
            }
            else
            {
                Balance -= amount;
                return true;
            }
            return base.Withdraw(amount);
        }
    }
}
