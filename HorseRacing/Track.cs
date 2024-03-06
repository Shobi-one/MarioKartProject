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
            soundManager = new SoundManager();
            int x;
            int y;
            switch (type)
            {
                case 0:
                    soundManager.LoadSound("mario", "mario.wav", true);
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
                    soundManager.PlaySound("mario");
                    break;

                case 1:
                    soundManager.LoadSound("choco", "choco.wav", true);
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
                    soundManager.PlaySound("choco");

                    break;

                case 2:
                    soundManager.LoadSound("bowser", "bowser.wav", true);
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
                    soundManager.PlaySound("bowser");
                    break;

                case 3:
                    soundManager.LoadSound("rainbow", "rainbow.wav", true);
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
                    soundManager.PlaySound("rainbow");
                    break;
            }

        }
    }
}