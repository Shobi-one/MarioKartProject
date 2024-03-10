﻿using System;
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
        private MoneyManager moneyManager;
        private double betAmount;

        private Font customFontHeader = FontManager.LoadEmbeddedFont(16f);
        private Font customFontSelection = FontManager.LoadEmbeddedFont(8f);

        public CharacterSelectView(int raceType)
        {
            InitializeComponent();
            moneyManager = new MoneyManager(100); //intialize the money for now will change later.
            Bitmap spriteSheet = new Bitmap(Properties.Resources.spritesheet);
            spriteRenderer = new SpriteRenderer(spriteSheet);

            // Render sprites for each character in PictureBoxes
            RenderCharacter(CharacterID.Mario, pboxBack1);
            RenderCharacter(CharacterID.Luigi, pboxBack2);
            RenderCharacter(CharacterID.Peach, pboxBack3);
            RenderCharacter(CharacterID.Bowser, pboxBack4);
        }

        private void Bet()
        {
            if (double.TryParse(txtBetAmount.Text, out betAmount))
            {
                // Ensure the user has enough money to place the bet
                if (betAmount <= moneyManager.Money)
                {
                    // Place the bet
                    moneyManager.DeductMoney(betAmount);
                    // Navigate back to MapSelectView and pass the bet amount
                    MapSelectView mapSelectView = new MapSelectView(1, betAmount);
                    mapSelectView.Show();
                    this.Hide(); // Hide the current form
                }
                else
                {
                    MessageBox.Show("Insufficient funds to place the bet.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid bet amount.");
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
            lblChoose.Font = customFontHeader;
        }

        private void btnBet_Click(object sender, EventArgs e)
        {
            Bet();
        }
    }
}