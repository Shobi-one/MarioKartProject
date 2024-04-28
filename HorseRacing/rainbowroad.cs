using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HorseRacing
{
    class rainbowroad : Race
    {
        public rainbowroad()
        {
            StartingPositions = new List<Point>
            {
                new Point(60, 480),
                new Point(30, 510),
                new Point(60, 520),
                new Point(30, 540),
            };

            Path = new List<Point>
            {
                new Point(70, 30),
                new Point(766, 30),
                new Point(735, 420),
                new Point(300, 420),
                new Point(300, 620),
                new Point(950, 630),
                new Point(950, 900),
                new Point(490, 930),
                new Point(440, 900),
                new Point(220, 900),
                new Point(171, 920),
                new Point(70, 920),
                new Point(66, 466)
            };
        }
    }
}