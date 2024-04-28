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
            pathIndices = new List<int> { 0, 0, 0, 0 };
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
            
            // Calculate the distance to move based on the speed
    
            // Get the current and next point
            Point currentPoint = kart.KartImage.Location;
            Point nextPoint = kart.Path[(pathIndices[kartIndex] + 1) % kart.Path.Count];
            //Console.WriteLine($"Kart {kartIndex}: Current Point = {currentPoint}, Next Point = {nextPoint}");
    
            // Calculate the direction vector
            PointF direction = new PointF(nextPoint.X - currentPoint.X, nextPoint.Y - currentPoint.Y);
            float length = (float)Math.Sqrt(direction.X * direction.X + direction.Y * direction.Y);
            if (length > 0)
            {
                direction.X /= length;
                direction.Y /= length;
            }
    
            // Move the PictureBox towards the next point
            float distance = MovementSpeedMultiplier;
            PointF newPosition = new PointF(currentPoint.X + direction.X * distance, currentPoint.Y + direction.Y * distance);
    
            // Check if the PictureBox has reached the next point
            if (Math.Abs(newPosition.X - nextPoint.X) < Math.Abs(direction.X * distance) &&
                Math.Abs(newPosition.Y - nextPoint.Y) < Math.Abs(direction.Y * distance))
            {
                newPosition = nextPoint;
                pathIndices[kartIndex] = (pathIndices[kartIndex] + 1) % kart.Path.Count;
                if (kartIndex == 0)
                {
                Console.WriteLine($"Kart {kartIndex}: Reached next point, updated path index to {pathIndices[kartIndex]}.");
                }
            }
    
            // Update PictureBox location
            kart.KartImage.Location = Point.Round(newPosition);
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

        private void GameView_Paint_1(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < CurrentRace.Path.Count; i++)
            {
                Point point = karts[0].Path[i];
                // Console.WriteLine($"{i}: {point.ToString()}");
                int dotSize = 10; // Adjust the size of the dot as needed
                e.Graphics.FillEllipse(Brushes.White, point.X - dotSize / 2, point.Y - dotSize / 2, dotSize, dotSize);

                // Draw the index number next to the dot
                string indexText = (i + 1).ToString(); // Add 1 to the index to start from 1
                Font font = new Font("Arial", 8); // Choose an appropriate font
                e.Graphics.DrawString(indexText, font, Brushes.White, point.X + dotSize, point.Y);
            }
        }
    }
}