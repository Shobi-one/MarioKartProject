using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using HorseRacing.Properties;

namespace HorseRacing
{
    public partial class GameView : Form
    {
        

        public GameView(Race race, int raceType)
        {
            InitializeComponent();

            Bitmap[] tracks = { Resources.mariocircuit_1, Resources.chocoisland_1, Resources.bowsercastle_3, Resources.rainbowroad };

            this.BackgroundImage = raceType == 0 ? race.Track : tracks[raceType - 1];
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        private void tick_Tick(object sender, EventArgs e)
        {
            
        }



        private void frmGame_Load(object sender, EventArgs e)
        {
            
        }
        

        private bool mouseDown;
        private Point lastLocation;
        private void GameView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDown = true;
                lastLocation = e.Location;
            }
        }
        private void GameView_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                // Calculate the new form position based on mouse movement
                int deltaX = e.X - lastLocation.X;
                int deltaY = e.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }

            lblX.Text = "X: " + e.X.ToString();
            lblY.Text = "Y: " + e.Y.ToString();
        }
        private void GameView_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}


