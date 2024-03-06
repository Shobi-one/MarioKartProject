using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorseRacing.Properties;

namespace HorseRacing
{
    public class Game
    {
        public MoneyManager Balance { get; set; }
        public List<Race> PreviousRaces { get; set; }


        public Game(MoneyManager balance)
        {
            this.Balance = balance;
        }

        public void AddRace(Race race)
        {
            PreviousRaces.Add(race);
        }
    }
}
