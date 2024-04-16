using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HorseRacing
{
    class bowsercastle : Race
    {
        public bowsercastle() : base()
        {
            StartingPositions = new List<Point>
            {
                new Point(900, 320),
                new Point(930, 340),
                new Point(900, 350),
                new Point(930, 370),
            };

            Path = new List<Point>
            {
                new Point(900, 320),
                new Point(900, 50),
                new Point(170, 50),
                new Point(120, 930),
                new Point(420, 930),
                new Point(440, 320),
                new Point(620, 320),
                new Point(620, 920),
                new Point(860, 977),
                new Point(855, 690),
                new Point(900, 650),
                new Point(900, 320)
            };
        }
    }
}
