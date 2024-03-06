using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorseRacing.Properties;

namespace HorseRacing
{
    public class Track
    {
        public List<int[]> StartingPositions { get; set; }
        public Bitmap Background {  get; }
        public List<int[]> path { get; set; }

        public Track(Bitmap background)
        {
            this.Background = background;
        }
    }
}