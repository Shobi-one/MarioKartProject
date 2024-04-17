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
        public PictureBox KartImage { get; set; }

        public Kart(CharacterID kartID, int speed, PictureBox kartImage, List<Point> path)
        {
            KartID = kartID;
            Speed = speed;
            KartImage = kartImage;
            Path = path;
        }
    }
}