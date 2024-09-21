using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public enum AccountType
    {
        SAV = 1 , CHA = 2, INV = 3 , CRA = 4 , AccountNumLenght = 7
    }
    public abstract class BankAccount
    {
        #region AccountInfo
        public readonly string AccountNumber;

        public string AccountHolderName { get; protected set; }

        protected decimal Balance;
        #endregion

        #region AccountMethods
        public decimal CheckBalance()
        {
            return Balance;
        }

        public void Deposit(decimal amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("Error. Negative amount Not allowed");
            }
            Balance += amount;
        }

        public virtual bool Withdraw(decimal amount)
        {
            if(amount <= 0)
            {
                Console.WriteLine("Unacceptable operation!");
                return false;
            }
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            Console.WriteLine("Low balance");
            return false;
        }
        #endregion

        #region AccountCtor

        public BankAccount(AccountType accountType, string accountHolderName , decimal amount)
        {
            Balance = amount;
            var rand = new Random();
            int len = (int)Math.Pow(10, (int)AccountType.AccountNumLenght);
            AccountNumber = accountType.ToString() + ((int)accountType * (len) + rand.Next(0, len));
            AccountHolderName = accountHolderName;
        } 
        #endregion
    }
    
}
