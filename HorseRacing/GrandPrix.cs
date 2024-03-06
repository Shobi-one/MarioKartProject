using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorseRacing.Properties;

namespace HorseRacing
{
    public class GrandPrix : Race
    {
        public List<Race> Races { get; set;  }

        public GrandPrix()
        {
            Races = new List<Race>()
            {
                new Race(Resources.mariocircuit_1),
                new Race(Resources.chocoisland_1),
                new Race(Resources.bowsercastle_3),
                new Race(Resources.rainbowroad)
            };
        }
    }
}
