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
        private Race CurrentRace
        {
            get { return Program.CurrentGame.CurrentRace; }
            set { Program.CurrentGame.CurrentRace = value; }
        }
        
        private SpriteRenderer spriteRenderer;
        public frmEndGameView()
        {
            InitializeComponent();
            spriteRenderer = new SpriteRenderer();
        }

        public void standings()
        {
            for (int i = 0; i < CurrentRace.FinishedCharacters.Count; i++)
            {
                Console.WriteLine(CurrentRace.FinishedCharacters[i].KartID + " finished in " + i+1 + " place");
                
                // TODO: Implement rendering of characters in the correct order
                // RenderCharacter(kart, pictureBox1);
            }
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