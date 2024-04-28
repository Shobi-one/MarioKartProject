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
using HorseRacing.Properties;

namespace HorseRacing
{
    public partial class CharacterSelectView : Form
    {
        private SpriteRenderer spriteRenderer;
        private CharacterID selectedCharacter;

        private Font customFontHeader = FontManager.LoadEmbeddedFont(16f);
        private Font customFontSelection = FontManager.LoadEmbeddedFont(8f);

        public CharacterSelectView()
        {
            InitializeComponent();
            spriteRenderer = new SpriteRenderer();

            // Render sprites for each character in PictureBoxes
            RenderCharacter(CharacterID.Mario, pboxBack1);
            RenderCharacter(CharacterID.Luigi, pboxBack2);
            RenderCharacter(CharacterID.Peach, pboxBack3);
            RenderCharacter(CharacterID.Bowser, pboxBack4);

            pboxBack1.Location = new Point(68, 111);
            pboxBack2.Location = new Point(236, 111);
            pboxBack3.Location = new Point(404, 111);
            pboxBack4.Location = new Point(571, 111);
        }
        
        private void btnBet_Click(object sender, EventArgs e)
        {
            double betAmount;
            if (double.TryParse(txtBetAmount.Text, out betAmount))
            {
                // Ensure the user has enough money to place the bet
                if (betAmount <= Program.CurrentGame.Balance.Money)
                {
                    // Place the bet
                    Program.CurrentGame.Balance.DeductMoney(betAmount);
                    Program.CurrentGame.CurrentRace.SelectedCharacter = selectedCharacter;
                    Program.CurrentGame.CurrentRace.Bet = betAmount;
                    Hide();
                    new GameView().Show();
                }
                else
                {
                    MessageBox.Show(@"Insufficient funds to place the bet.");
                }
            }
            else
            {
                MessageBox.Show(@"Please enter a valid bet amount.");
            }
        }

        private void RenderCharacter(CharacterID characterID, PictureBox pictureBox)
        {
            // Render sprite for the given character into the PictureBox
            spriteRenderer.RenderSprite(pictureBox, characterID, 9);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void CharacterSelectView_Load(object sender, EventArgs e)
        {
            lblMoneyText.Text += " " + Program.CurrentGame.Balance.Money; 
        }
        private void rdbMariocircuit_CheckedChanged(object sender, EventArgs e)
        {
            selectedCharacter = CharacterID.Mario;
        }
        private void rdbChocoIsland_CheckedChanged(object sender, EventArgs e)
        {
            selectedCharacter = CharacterID.Luigi;

        }
        private void rdbBowsersCastle_CheckedChanged(object sender, EventArgs e)
        {
            selectedCharacter = CharacterID.Peach;

        }
        private void rdbRainbowRoad_CheckedChanged(object sender, EventArgs e)
        {
            selectedCharacter = CharacterID.Bowser;

        }

        private void pboxBack1_Click(object sender, EventArgs e)
        {
            rdbMariocircuit.Checked = true;
            rdbChocoIsland.Checked = false;
            rdbBowsersCastle.Checked = false;
            rdbRainbowRoad.Checked = false;
        }

        private void pboxBack2_Click(object sender, EventArgs e)
        {
            rdbMariocircuit.Checked = false;
            rdbChocoIsland.Checked = true;
            rdbBowsersCastle.Checked = false;
            rdbRainbowRoad.Checked = false;
        }

        private void pboxBack3_Click(object sender, EventArgs e)
        {
            rdbMariocircuit.Checked = false;
            rdbChocoIsland.Checked = false;
            rdbBowsersCastle.Checked = true;
            rdbRainbowRoad.Checked = false;
        }

        private void pboxBack4_Click(object sender, EventArgs e)
        {
            rdbMariocircuit.Checked = false;
            rdbChocoIsland.Checked = false;
            rdbBowsersCastle.Checked = false;
            rdbRainbowRoad.Checked = true;
        }
    }
}