using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HorseRacing
{
    class chocoisland : Race 
    {
        public chocoisland() : base()
        {
            StartingPositions = new List<Point>
            {
                new Point(860, 600),
                new Point(900, 620),
                new Point(860, 640),
                new Point(900, 650),
            };

            Path = new List<Point>
            {
                new Point(866, 600),
                new Point(866, 433),
                new Point(700, 295),
                new Point(830, 802),
                new Point(583, 102),
                new Point(398, 143),
                new Point(335, 205),
                new Point(240, 300),
                new Point(236, 440),
                new Point(100, 520),
                new Point(95, 913),
                new Point(426, 852),
                new Point(849, 900),
                new Point(866, 600)
            };
        }
    }
}
