using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BankSystem
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(string accountHolderName , decimal balance) : base(AccountType.CHA, accountHolderName , balance)
        {

        }
    }
    
}
