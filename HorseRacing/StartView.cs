using System.Drawing;
using System.Windows.Forms;
using HorseRacing.Properties;

namespace HorseRacing
{
    public partial class StartView : Form
    {
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
    }
}