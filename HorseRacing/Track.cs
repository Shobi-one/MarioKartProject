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
        public int[][] StartingPositions { get; set; }
        public Bitmap Background {  get; }
        public List<int[]> Path { get; set; }
        public SoundManager soundManager;

        public Track(int type)
        {
            int x;
            int y;
            switch (type)
            {
                case 0:
                    Background = Resources.mariocircuit_1;
                    x = 912;
                    y = 576;
                    StartingPositions = new int[][]
                    {
                        new int[] {x, y},
                        new int[] {x, y+ (50 * 1) + 15 },
                        new int[] {x, y+ (50 * 2) + 30 },
                        new int[] {x, y+ (50 * 3) + 45 }
                    };
                    break;

                case 1:
                    Background = Resources.chocoisland_1;
                    x = 871;
                    y = 571;
                    StartingPositions = new int[][]
                    {
                        new int[] {x, y},
                        new int[] {x, y+ (50 * 1) + 15 },
                        new int[] {x, y+ (50 * 2) + 30 },
                        new int[] {x, y+ (50 * 3) + 45 }
                    };
                    break;

                case 2:
                    Background = Resources.bowsercastle_3;
                    x = 912;
                    y = 576;
                    StartingPositions = new int[][]
                    {
                        new int[] {x, y},
                        new int[] {x, y+ (50 * 1) + 15 },
                        new int[] {x, y+ (50 * 2) + 30 },
                        new int[] {x, y+ (50 * 3) + 45 }
                    };
                    break;

                case 3:
                    Background = Resources.rainbowroad;
                    x = 912;
                    y = 576;
                    StartingPositions = new int[][]
                    {
                        new int[] {x, y},
                        new int[] {x, y+ (50 * 1) + 15 },
                        new int[] {x, y+ (50 * 2) + 30 },
                        new int[] {x, y+ (50 * 3) + 45 }
                    };
                    break;
            }

        }
    }
}