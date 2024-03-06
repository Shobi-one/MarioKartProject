using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    public class MoneyManager
    {
        public double Money { get; private set; }

        public MoneyManager(double initialMoney)
        {
            Money = initialMoney;
        }

        public void AddMoney(double amount)
        {
            Money += amount;
        }

        public void DeductMoney(double amount)
        {
            Money -= amount;
        }
    }
}
