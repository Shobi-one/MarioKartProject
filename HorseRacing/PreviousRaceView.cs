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
    public partial class PreviousRaceView : Form
    {
        private Game _game;
        private SpriteRenderer spriteRenderer;

        public PreviousRaceView(Game game)
        {
            _game = game;
            InitializeComponent();
            InitializeCustomPanels();
        }

        private void InitializeCustomPanels()
        {
            if (_game.PreviousRaces == null || _game.PreviousRaces.Count == 0)
            {
                // Display a label saying no previous races found
                Label noRacesLabel = new Label
                {
                    Text = "No previous races found",
                    AutoSize = true,
                    Location = new Point(10, 10),
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    ForeColor = Color.Red
                };
                this.Controls.Add(noRacesLabel);
            }

            int panelWidth = 390;
            int panelHeight = 150;
            int horizontalSpacing = 5;
            int verticalSpacing = 20;

            int numberOfRaces = _game.PreviousRaces.Count;
            this.AutoScroll = true;

            for (int raceIndex = 0; raceIndex < numberOfRaces; raceIndex++)
            {
                Panel panel = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Location = new Point(horizontalSpacing, verticalSpacing + raceIndex * (panelHeight + verticalSpacing)),
                    Size = new Size(panelWidth, panelHeight)
                };

                Race race = _game.PreviousRaces[raceIndex];

                Label label = new Label
                {
                    Text = $"Race {raceIndex + 1}: Winner ID - {race.FinishedCharacters[0].KartID}",
                    Location = new Point(10, 10),
                    Size = new Size(panelWidth - 20, 20),
                    AutoSize = true
                };
                panel.Controls.Add(label);

                for (int i = 0; i < race.FinishedCharacters.Count; i++)
                {
                    PictureBox pictureBox = new PictureBox
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(10 + i * 60, 40),
                        Size = new Size(50, 50),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };
                    spriteRenderer.RenderSprite(pictureBox, race.FinishedCharacters[i].KartID, 9);
                    panel.Controls.Add(pictureBox);
                }
                this.Controls.Add(panel);
            }
        }
    }
}
