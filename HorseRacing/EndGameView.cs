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
    public partial class frmEndGameView : Form
    {
        public Race race;
        private SpriteRenderer spriteRenderer;
        public frmEndGameView()
        {
            InitializeComponent();
            spriteRenderer = new SpriteRenderer();
        }

        public void standings()
        {
            // RenderCharacter(Race.FirstPlace, pboxBack1);
            // RenderCharacter(Race.SecondPlace, pboxBack2);
            // RenderCharacter(Race.ThirdPlace, pboxBack3);
            // RenderCharacter(Race.FourthPlace, pboxBack4);
            //
            // if (race.SelectedCharacter == race.FirstPlace)
            // {
            //     
            // }
        }

        private void RenderCharacter(CharacterID characterID, PictureBox pictureBox)
        {
            // Render sprite for the given character into the PictureBox
            spriteRenderer.RenderSprite(pictureBox, characterID, 9);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void lblChoose_Click(object sender, EventArgs e)
        {

        }

        private void trackPicker_Enter(object sender, EventArgs e)
        {

        }
    }
}