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
        public List<Point> PathPoints { get; set; }
        public int CharacterID { get; set; }
        public int FirstPlace { get; set; }
        public int SecondPlace { get; set; }
        public int ThirdPlace { get; set; }
        public int FourthPlace { get; set; }
        public int Bet { get; set; }

        public Race() { }

        public Race(Bitmap track, List<Point> pathPoints)
        {
            Track = track;
            PathPoints = pathPoints;
            CharacterID = 0;
            FirstPlace = 0;
            Bet = 0;
        }

    }
}
