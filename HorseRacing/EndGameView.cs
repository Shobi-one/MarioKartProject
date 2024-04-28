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
            standings();
            pbFirst.Location = new Point(68, 111);
            pbSecond.Location = new Point(236, 111);
            pbThird.Location = new Point(404, 111);
            pbFourth.Location = new Point(571, 111);
        }

        public void standings()
        {
            var pictureBoxes = new List<PictureBox> { pbFirst, pbSecond, pbThird, pbFourth };

            for (int i = 0; i < CurrentRace.FinishedCharacters.Count && i < pictureBoxes.Count; i++)
            {
                RenderCharacter(CurrentRace.FinishedCharacters[i].KartID, pictureBoxes[i]);
                Console.WriteLine($"{CurrentRace.FinishedCharacters[i].KartID} finished in {i + 1} place");
            }
        }

        private void RenderCharacter(CharacterID characterID, PictureBox pictureBox)
        {
            // Render sprite for the given character into the PictureBox
            spriteRenderer.RenderSprite(pictureBox, characterID, 9);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new StartView();
        }
    }
}