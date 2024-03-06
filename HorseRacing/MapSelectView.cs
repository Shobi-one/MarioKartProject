using System;
using System.Drawing;
using System.Windows.Forms;
using HorseRacing.Properties;

namespace HorseRacing
{
    public partial class MapSelectView : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private int RaceType;

        public MapSelectView(int raceType)
        {
            InitializeComponent();
            this.RaceType = raceType;
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            Bitmap track;

            // TODO: Implement character selection and betting
            int characterID = 0;
            double bet = 0;

            if (rdbMariocircuit.Checked)
            {
                track = Resources.mariocircuit_1;
            }
            else if(rdbChocoIsland.Checked) 
            {
                track = Resources.chocoisland_1;
            }
            else if (rdbBowsersCastle.Checked)
            {
                track = Resources.bowsercastle_3;
            }
            else
            {
                track = Resources.rainbowroad;
            }

            Race currentRace = RaceType == 0 ? new Race(track) : new GrandPrix() ;
            currentRace.CharacterID = characterID;
            currentRace.Bet = 0;

            this.Hide();
            new GameView(currentRace, RaceType).Show();
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