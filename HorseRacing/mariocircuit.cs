using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HorseRacing
{
    class mariocircuit :  Race
    {
        public mariocircuit()
        {
            StartingPositions = new List<Point>
            {
                new Point(910, 610),
                new Point(940, 630),
                new Point(910, 640),
                new Point(940, 670),
            };

            Path = new List<Point>
            {
                new Point(935, 350),
                new Point(221, 50),
                new Point(144, 85),
                new Point(100, 124),
                new Point(88, 168),
                new Point(70, 222),
                new Point(70, 730),
                new Point(470, 540),
                new Point(722, 872),
                new Point(752, 872),
                new Point(903, 872),
                new Point(903, 580)
            };
        }
    }
}