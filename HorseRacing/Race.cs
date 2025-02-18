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
        public List<Kart> FinishedCharacters { get; set; }
        public double Bet { get; set; }
        public int Rotation { get; set; }

        public Race()
        {
            FinishedCharacters = new List<Kart>();
        }
    }
}