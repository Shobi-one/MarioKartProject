using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace HorseRacing
{
    public class Kart
    {
        public CharacterID KartID { get; set; }
        public int Speed { get; set; }
        public List<Point> Path { get; set; }

        public Kart(CharacterID kartID)
        {
            KartID = kartID;
            Speed = new Random().Next(3, 6);
            Path = new List<Point>();
        }
    }
}