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
        private List<Kart> karts = new List<Kart>();
        private List<Timer> timers;   
        private List<int> pathIndices;
        private const int MovementSpeedMultiplier = 5;

        private Race CurrentRace
        {
            get { return Program.CurrentGame.CurrentRace; }
            set { Program.CurrentGame.CurrentRace = value; }
        }

        private SpriteRenderer spriteRenderer;
        
        public GameView()
        {
            InitializeComponent();
            BackgroundImage = CurrentRace.Track;

            RenderCharacters();
            CreateCharacters();
            InitializeAnimation();
        }

        private void InitializeAnimation()
        {
            pathIndices = new List<int> { -1, -1, -1, -1 };
            timers = new List<Timer>();
            for (int i = 0; i < karts.Count; i++)
            {
                Timer timer = new Timer();
                timer.Interval = 10 * karts[i].Speed;
                timer.Tick += AnimationTimer_Tick;
                timer.Tag = i;
                timer.Start();
                timers.Add(timer);
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            int kartIndex = (int)timer.Tag;
            Kart kart = karts[kartIndex];
            PictureBox kartImage = kart.KartImage;
            List<Point> path = kart.Path;

            if (pathIndices[kartIndex] < path.Count - 1)
            {
                // Get the current and next points in the path
                Point currentPoint = kartImage.Location;
                Point nextPoint = path[(pathIndices[kartIndex] + 1) % path.Count];

                // Calculate the distance between the current point and the next point
                double distance = Math.Sqrt(Math.Pow(nextPoint.X - currentPoint.X, 2) + Math.Pow(nextPoint.Y - currentPoint.Y, 2));

                // Calculate the ratio of the MovementSpeedMultiplier to the distance
                double ratio = MovementSpeedMultiplier / distance;

                // Calculate the amount of movement along the x and y axes
                int movementX = (int)((nextPoint.X - currentPoint.X) * ratio);
                int movementY = (int)((nextPoint.Y - currentPoint.Y) * ratio);

                // Add the movement to the current position of the kart to get the new position
                Point newPosition = new Point(kartImage.Location.X + movementX, kartImage.Location.Y + movementY);

                // Update the position of the kart
                kartImage.Location = newPosition;

                // If the kart has reached the next point, increment the path index for that kart
                if (Math.Sqrt(Math.Pow(newPosition.X - nextPoint.X, 2) + Math.Pow(newPosition.Y - nextPoint.Y, 2)) < MovementSpeedMultiplier)
                {
                    pathIndices[kartIndex] = (pathIndices[kartIndex] + 1) % path.Count;
                }
            }
            else
            {
                timer.Stop();
                timer.Dispose();
            }
        }

        private void RenderCharacters()
        {
            spriteRenderer = new SpriteRenderer();
            spriteRenderer.RenderSprite(pbMario, CharacterID.Mario, 0);
            pbMario.SizeMode = PictureBoxSizeMode.Zoom;
            
            spriteRenderer.RenderSprite(pbLuigi, CharacterID.Luigi, 0);
            pbLuigi.SizeMode = PictureBoxSizeMode.Zoom;
            
            spriteRenderer.RenderSprite(pbPeach, CharacterID.Peach, 0);
            pbPeach.SizeMode = PictureBoxSizeMode.Zoom;
            
            spriteRenderer.RenderSprite(pbBowser, CharacterID.Bowser, 0);
            pbBowser.SizeMode = PictureBoxSizeMode.Zoom;
        }
        private void CreateCharacters()
        {
            // Generates 4 random speeds for the karts
            Random rand = new Random();
            List<int> speeds = Enumerable.Range(3, 4).OrderBy(x => rand.Next()).ToList();
            
            pbMario.Location = CurrentRace.StartingPositions[0];
            pbLuigi.Location = CurrentRace.StartingPositions[1];
            pbPeach.Location = CurrentRace.StartingPositions[2];
            pbBowser.Location = CurrentRace.StartingPositions[3];
            
            karts.Add(new Kart(CharacterID.Mario, speeds[0], pbMario, CurrentRace.Path));
            karts.Add(new Kart(CharacterID.Luigi, speeds[1], pbLuigi, CurrentRace.Path));
            karts.Add(new Kart(CharacterID.Peach, speeds[2], pbPeach, CurrentRace.Path));
            karts.Add(new Kart(CharacterID.Bowser, speeds[3], pbBowser, CurrentRace.Path));

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

            lblX.Text = "X: " + e.X.ToString();
            lblY.Text = "Y: " + e.Y.ToString();
        }
        private void GameView_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void GameView_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < CurrentRace.Path.Count; i++)
            {
                Point point = karts[0].Path[i];
                // Console.WriteLine($"{i}: {point.ToString()}");
                int dotSize = 10; // Adjust the size of the dot as needed
                e.Graphics.FillEllipse(Brushes.Red, point.X - dotSize / 2, point.Y - dotSize / 2, dotSize, dotSize);
                
                // Draw the index number next to the dot
                string indexText = (i + 1).ToString(); // Add 1 to the index to start from 1
                Font font = new Font("Arial", 8); // Choose an appropriate font
                e.Graphics.DrawString(indexText, font, Brushes.Red, point.X + dotSize, point.Y);
            }
        }
    }
}