using System;
using System.Collections.Generic;
using System.Text;

namespace BonusApp
{
    public delegate double DG_BonusProvider(double amount);

    class Bonuses
    {
        public double TenPercent(double amount)
        {
            return (amount / 100 * 10);
        }
        public double FlatTwoIfAmountMoreThanFive (double amount)
        {
            if (amount > 5)
            {
                amount = 2.0;
            }
            else
            {
                amount = 0.0;
            }
            return amount; 
        }
    }
}
