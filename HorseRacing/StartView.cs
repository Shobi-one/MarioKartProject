using System.Drawing;
using System.Windows.Forms;
using HorseRacing.Properties;

namespace HorseRacing
{
    public partial class StartView : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        private SoundManager soundManager;

        public StartView()
        {
            InitializeComponent();
            soundManager = new SoundManager();
            soundManager.LoadSound("MenuMusic", "menu.wav", true);
            soundManager.PlaySound("MenuMusic");
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            soundManager.StopSound("MenuMusic");
            int trackType = 0;
            if (rdbMariocircuit.Checked)
            {
                trackType = 0;
            }
            else if(rdbChocoIsland.Checked) 
            {
                trackType = 1;
            }
            else if (rdbBowsersCastle.Checked)
            {
                trackType = 2;
            }
            else if (rdbRainbowRoad.Checked)
            {
                trackType = 3;
            }

            Track track = new Track(trackType);
            GameView gameView = new GameView(track);
            gameView.Show();
            this.Hide();
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

        private void StartView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }

        private void StartView_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Calculate the new form position based on mouse movement
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }

        }

        private void StartView_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}