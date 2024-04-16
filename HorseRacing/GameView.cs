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
        private List<PictureBox> kartImages = new List<PictureBox>();
        private Race CurrentRace
        {
            get { return Program.CurrentGame.CurrentRace; }
            set { Program.CurrentGame.CurrentRace = value; }
        }
        
        private SpriteRenderer spriteRenderer;
        
        private int[] pointIndex = { 0, 0, 0, 0 };
        
        public GameView()
        {
            InitializeComponent();
        
            spriteRenderer = new SpriteRenderer();
            BackgroundImage = CurrentRace.Track;
        
            RenderCharacters();
            CreateCharacters();
        }

        private void MoveKarts()
        {
            foreach (Kart kart in karts)
            {
                
            }
        }
        
        private void MoveKart()
        {
            // Calculate the distance and direction to the target position
            //
            // // Move Mario towards the target position
            // marioPosition = new Point(
            //     (int)(marioPosition.X + marioSpeed * directionX),
            //     (int)(marioPosition.Y + marioSpeed * directionY)
            // );
            // pbMario.Location = marioPosition;
            //
            // // Check if Mario has reached the target position
            // if (Math.Abs(marioPosition.X - targetPosition.X) < marioSpeed &&
            //     Math.Abs(marioPosition.Y - targetPosition.Y) < marioSpeed)
            // {
            //     // Mark the current target position as visited
            //     marioVisitedPoints.Add(targetPosition);
            //
            //     // Move to the next target position if available and not visited
            //     for (int i = marioPointIndex + 1; i < mariopathPoints.Count; i++)
            //     {
            //         if (!marioVisitedPoints.Contains(mariopathPoints[i]))
            //         {
            //             marioPointIndex = i;
            //             targetPosition = mariopathPoints[marioPointIndex];
            //             break;
            //         }
            //     }
            // }
        }
        
        
        private void GameTick_tick(object sender, EventArgs e)
        {
            MoveKarts();

        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            GameTick.Enabled = true;
        }
        
        private void RenderCharacters()
        {
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
            kartImages.Add(pbMario);
            kartImages.Add(pbLuigi);
            kartImages.Add(pbPeach);
            kartImages.Add(pbBowser);
            
            karts.Add(new Kart(CharacterID.Mario));
            karts.Add(new Kart(CharacterID.Luigi));
            karts.Add(new Kart(CharacterID.Peach));
            karts.Add(new Kart(CharacterID.Bowser));
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
    }
}