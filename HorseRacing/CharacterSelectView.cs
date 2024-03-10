using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HorseRacing
{
    public partial class CharacterSelectView : Form
    {
        private SpriteRenderer spriteRenderer;
        public CharacterSelectView(int raceType)
        {
            InitializeComponent();
            Bitmap spriteSheet = new Bitmap(Properties.Resources.spritesheet);
            spriteRenderer = new SpriteRenderer(spriteSheet);

            // Render sprites for each character in PictureBoxes
            RenderCharacter(CharacterID.Mario, pboxBack1);
            RenderCharacter(CharacterID.Luigi, pboxBack2);
            RenderCharacter(CharacterID.Peach, pboxBack3);
            RenderCharacter(CharacterID.Bowser, pboxBack4);
        }

        private void RenderCharacter(CharacterID characterID, PictureBox pictureBox)
        {
            // Render sprite for the given character into the PictureBox
            spriteRenderer.RenderSprite(pictureBox, characterID, 9);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }


        private void CharacterSelectView_Load(object sender, EventArgs e)
        {

        }
    }
}
