using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem
{
    public static class Calc
    {
        public static void Calculate(this IInterestEarning inter, DateTime start, DateTime end)
        {
            if (inter is not BankAccount) return;
            if (inter is null) return;
            int span = (int)(end.Subtract(start).Days / (365.25 / 12));
            var amount = inter.CalculateInterest() * span;
            inter.ApplyInterest(amount , span );
        }
    }
}
