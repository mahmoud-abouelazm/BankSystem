using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public interface IInterestEarning
    {
        public  decimal CalculateInterest();
        public void ApplyInterest(decimal amount , int mounthes);
    }
}
