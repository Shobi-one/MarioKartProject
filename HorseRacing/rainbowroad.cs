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
                new Point(66, 466),
                new Point(70, 30),
                new Point(766, 30),
                new Point(735, 42),
                new Point(300, 42),
                new Point(300, 62),
                new Point(300, 62),
                new Point(950, 63),
                new Point(950, 90),
                new Point(490, 90),
                new Point(440, 87),
                new Point(220, 87),
                new Point(171, 90),
                new Point(70, 880),
                new Point(66, 466)
            };
        }
    }
}