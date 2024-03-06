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
        private PictureBox[] horses;
        private List<Horse> horseSpeeds;
        private Label lblMoney;
        private Random random;
        private MoneyManager moneyManager;
        private SpriteRenderer spriteRenderer;
        private Font customFont;
        private string vote;
        private Game Game;

        public GameView(Track track)
        {
            InitializeComponent();
            random = new Random();
            horseSpeeds = new List<Horse>();
            moneyManager = new MoneyManager(100);
            Bitmap spriteSheet = Properties.Resources.spritesheet;
            spriteRenderer = new SpriteRenderer(spriteSheet);
            customFont = FontManager.LoadEmbeddedFont(12f);
            Game = new Game(track);
            this.BackgroundImage = track.Background;

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Start the race
            tick.Start();
            // Hide vote radio buttons
            foreach (Control control in Controls)
            {
                if (control is RadioButton rb)
                {
                    rb.Visible = false;
                }
            }
            // Disable the start button after the game starts
            btnStart.Enabled = false;
        }

        private void tick_Tick(object sender, EventArgs e)
        {
            int finishLine = ClientSize.Width - 100;
            PictureBox winningHorse = null;

            // List to store horses and their positions
            List<(Horse horse, int position)> horsePositions = new List<(Horse horse, int position)>();

            for (int i = 0; i < horses.Length; i++)
            {
                PictureBox horsePictureBox = horses[i];
                Horse horseSpeed = horseSpeeds[i];

                if (horsePictureBox.Right <= finishLine)
                {
                    horsePictureBox.Left += horseSpeed.Speed;
                }
                else
                {
                    // Record the winning horse when it crosses the finish line
                    if (winningHorse == null)
                    {
                        winningHorse = horsePictureBox;
                    }
                }

                // Store horse position along with the horse object
                horsePositions.Add((horseSpeed, horsePictureBox.Left)); // Store the left position of the horse
            }

            if (winningHorse != null)
            {
                btnStart.Enabled = false;
                tick.Stop();
                MessageBox.Show($"Race finished! You voted for {vote}");

                // Sort the horse positions based on their finishing positions
                horsePositions = horsePositions.OrderBy(h => h.position).ToList(); // Sort positions

                // Display positions of horses
                MessageBox.Show($"1st Place: {horsePositions[3].horse.Name}\n" +
                                $"2nd Place: {horsePositions[2].horse.Name}\n" +
                                $"3rd Place: {horsePositions[1].horse.Name}\n" +
                                $"4th Place: {horsePositions[0].horse.Name}");

                // Determine the winning horse by name
                string winningHorseName = horsePositions[3].horse.Name;

                // Determine if the player's horse won
                bool playerWon = (vote == winningHorseName);

                if (playerWon)
                {
                    MessageBox.Show("Congratulations! You won the bet!");
                    moneyManager.AddMoney(50);
                }
                else
                {
                    MessageBox.Show("Sorry, you lost the bet!");
                    moneyManager.DeductMoney(20);
                }

                // Show the updated money
                MessageBox.Show($"Current money: {moneyManager.Money}");
                lblMoney.Text = $"Current money: {moneyManager.Money}";
                btnReset.Enabled = true; // Enable Reset button after the game ends
            }
        }



        private void frmGame_Load(object sender, EventArgs e)
        {
            customFont = FontManager.LoadEmbeddedFont(12f);
            horses = new PictureBox[4];

            PlaceHorses();
            btnStart.Enabled = false;
            btnReset.Enabled = false;

            lblX.Font = customFont;
            lblY.Font = customFont;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            horseSpeeds.Clear();
            // Clear all controls from the form
            Controls.Clear();

            // Reinitialize horses array
            horses = new PictureBox[4];

            // Generate and place new horses
            PlaceHorses();
            lblMoney.Visible = true;

            btnReset.Enabled = false; // Disable Reset button after it's pressed
        }

        private void PlaceHorses()
        {
            for (int i = 0; i < 4; i++)
            {
                Horse horse;
                bool isDuplicate;

                do
                {
                    horse = Horse.GenerateHorse();
                    isDuplicate = false;

                    // Check for duplicates
                    foreach (Horse existingHorse in horseSpeeds)
                    {
                        if (existingHorse.Name == horse.Name)
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                } while (isDuplicate);

                horseSpeeds.Add(horse);

                // Add PictureBox for horse
                PictureBox pbHorse = new PictureBox();
                pbHorse.Name = horse.Name;
                pbHorse.SizeMode = PictureBoxSizeMode.Zoom;
                pbHorse.Size = new System.Drawing.Size(50, 50);
                pbHorse.Location = new System.Drawing.Point(Game.Track.StartingPositions[i][0], Game.Track.StartingPositions[i][1]);
                Controls.Add(pbHorse);

                horses[i] = pbHorse;

                // Add radio button for voting
                RadioButton rbVote = new RadioButton();
                rbVote.Text = "Vote";
                rbVote.AutoSize = true;
                rbVote.Location = new System.Drawing.Point(i*100 + 100, 1100);
                rbVote.CheckedChanged += (s, ev) =>
                {
                    if (rbVote.Checked)
                    {
                        MessageBox.Show($"You voted for {horse.Name}");
                        vote = horse.Name;
                        btnStart.Enabled = true;
                    }
                };
                Controls.Add(rbVote);
            }
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
            customFont = FontManager.LoadEmbeddedFont(12f);
            lblX.Font = customFont;
            lblY.Font = customFont;

            lblX.Text = "X: " + e.X.ToString();
            lblY.Text = "Y: " + e.Y.ToString();
        }

        private void GameView_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
    }
}


