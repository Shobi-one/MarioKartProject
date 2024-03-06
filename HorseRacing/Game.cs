using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HorseRacing.Properties;

namespace HorseRacing
{
    public class Game
    {
        public Track Track { get; set; }

        public Game(Track track)
        {
            this.Track = track;
        }
    }
}
