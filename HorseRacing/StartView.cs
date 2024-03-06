using System.Drawing;
using System.Windows.Forms;
using HorseRacing.Properties;

namespace HorseRacing
{
    public partial class StartView : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public StartView()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            Bitmap background = null;
            if (rdbMariocircuit.Checked)
            {
                background = Resources.mariocircuit_1;
            }
            else if(rdbChocoIsland.Checked) 
            {
                background = Resources.chocoisland_1;
            }
            else if (rdbBowsersCastle.Checked)
            {
                background = Resources.bowsercastle_3;
            }
            else if (rdbRainbowRoad.Checked)
            {
                background = Resources.rainbowroad;
            }


            GameView gameView = new GameView(background);
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