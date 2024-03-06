using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorseRacing
{
    public class Race
    {
        public Bitmap Track { get; set; }
        public int CharacterID { get; set; }
        public int FirstPlace { get; set; }
        public int Bet { get; set; }

        public Race() { }

        public Race(Bitmap track)
        {
            Track = track;
            CharacterID = 0;
            FirstPlace = 0;
            Bet = 0;
        }
    }
}
