using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{
    public enum CharacterID
    {
        Mario,
        Luigi,
        Peach,
        Bowser,
        Null
    }
    
    static class Program
    {
        public static Game CurrentGame { get; set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MoneyManager balance = new MoneyManager(100);
            CurrentGame = new Game(balance);

            SpriteRenderer spriteRenderer = new SpriteRenderer();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new StartView());
        }
    }
}