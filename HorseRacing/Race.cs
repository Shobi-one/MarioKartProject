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
        public List<Point> StartingPositions { get; set; }
        public List<Point> Path { get; set; }
        public CharacterID SelectedCharacter { get; set; }
        public CharacterID FirstPlace { get; set; }
        public CharacterID SecondPlace { get; set; }
        public CharacterID ThirdPlace { get; set; }
        public CharacterID FourthPlace { get; set; }
        public double Bet { get; set; }

        public Race() { }

        public Race(Bitmap track)
        {
            Track = track;
            FirstPlace = 0;
            Bet = 0;
        }

        
    }
}