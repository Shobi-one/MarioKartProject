using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorseRacing
{
    public partial class StartView : Form
    {
        private SoundManager soundManager;
        public StartView()
        {
            InitializeComponent();
        }

        private void Start(object sender, EventArgs e)
        {
            soundManager = new SoundManager();
            soundManager.LoadSound("title", "title.wav", true);
            soundManager.PlaySound("title");
            int raceType = 0;
            if (sender == btnGrandPrix)
                raceType = 1;
            this.Hide();
            new MapSelectView(raceType).Show();
        }

        private bool mouseDown;
        private Point lastLocation;

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
