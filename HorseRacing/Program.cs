using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{
    static class Program
    {
        static Game game;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MoneyManager balance = new MoneyManager(100);
            Game game = new Game(balance);

            Bitmap spriteSheet = Properties.Resources.spritesheet;
            SpriteRenderer spriteRenderer = new SpriteRenderer(spriteSheet);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MapSelectView());
        }
    }
}
