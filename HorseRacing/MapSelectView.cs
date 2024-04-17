using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HorseRacing.Properties;

namespace HorseRacing
{
    public partial class MapSelectView : Form
    {
        private bool mouseDown;
        private double betAmount = 0;

        private Point lastLocation;

        private Font customFontHeader = FontManager.LoadEmbeddedFont(16f);
        private Font customFontSelection = FontManager.LoadEmbeddedFont(8f);
        private SoundManager soundManager;

        public MapSelectView()
        {
            InitializeComponent();
            
            soundManager = new SoundManager();
            soundManager.LoadSound("MenuMusic", "menu.wav", true);
            soundManager.PlaySound("MenuMusic");
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            Bitmap track;
            Race race;

            soundManager.StopSound("MenuMusic");
            if (rdbMariocircuit.Checked)
            {
                track = Resources.mariocircuit_1;
                race = new mariocircuit();
            }
            else if (rdbChocoIsland.Checked)
            {
                track = Resources.chocoisland_1;
                race = new chocoisland();
            }
            else if (rdbBowsersCastle.Checked)
            {
                track = Resources.bowsercastle_3;
                race = new bowsercastle();
            }
            else
            {
                track = Resources.rainbowroad;
                race = new rainbowroad();
            }
            race.Track = track;
            Program.CurrentGame.CurrentRace = race;

            Hide();
            new CharacterSelectView().Show();
        }

        private void pboxMarioCircuit_Click(object sender, System.EventArgs e)
        {
            rdbMariocircuit.Checked = true;
            rdbChocoIsland.Checked = false;
            rdbBowsersCastle.Checked = false;
            rdbRainbowRoad.Checked = false;
        }
        private void pboxChocoIsland_Click(object sender, System.EventArgs e)
        {
            rdbMariocircuit.Checked = false;
            rdbChocoIsland.Checked = true;
            rdbBowsersCastle.Checked = false;
            rdbRainbowRoad.Checked = false;
        }
        private void pboxBowsersCastle_Click(object sender, System.EventArgs e)
        {
            rdbMariocircuit.Checked = false;
            rdbChocoIsland.Checked = false;
            rdbBowsersCastle.Checked = true;
            rdbRainbowRoad.Checked = false;
        }
        private void pboxRainbowRoad_Click(object sender, System.EventArgs e)
        {
            rdbMariocircuit.Checked = false;
            rdbChocoIsland.Checked = false;
            rdbBowsersCastle.Checked = false;
            rdbRainbowRoad.Checked = true;
        }

        private void MapSelectView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void MapSelectView_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Calculate the new form position based on mouse movement
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void MapSelectView_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}