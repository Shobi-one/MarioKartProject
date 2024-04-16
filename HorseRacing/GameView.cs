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
        private SpriteRenderer spriteRenderer;
        private Point marioPosition;
        private Point luigiPositon;
        private Point targetPosition;

        private Point lastValidMarioPosition;

        private List<Point> mariopathPoints = new List<Point>();
        private List<Point> pathPoints = new List<Point>();
        private List<CharacterID> charactersStopping = new List<CharacterID>();

        private Dictionary<CharacterID, HashSet<Point>> visitedPoints = new Dictionary<CharacterID, HashSet<Point>>();

        private HashSet<Point> marioVisitedPoints = new HashSet<Point>();
        private HashSet<Point> luigiVisitedPoints = new HashSet<Point>();

        private int marioPointIndex = 0;
        private int luigiPointIndex = 0;

        private int marioSpeed = 5;
        private int luigiSpeed = 5;

        private Random random = new Random();
        private Timer stopTimer = new Timer();

        public GameView(Race race, int raceType)
        {
            InitializeComponent();
            Random random = new Random();

            Bitmap[] tracks = { Resources.mariocircuit_1, Resources.chocoisland_1, Resources.bowsercastle_3, Resources.rainbowroad };
            Bitmap spriteSheet = new Bitmap(Properties.Resources.spritesheet);
            spriteRenderer = new SpriteRenderer(spriteSheet);

            lastValidMarioPosition = marioPosition;
            visitedPoints.Add(CharacterID.Mario, new HashSet<Point>());
            visitedPoints.Add(CharacterID.Luigi, new HashSet<Point>());
            visitedPoints.Add(CharacterID.Peach, new HashSet<Point>());
            visitedPoints.Add(CharacterID.Bowser, new HashSet<Point>());

            marioPosition = new Point(903, 580);
            mariopathPoints.Add(new Point(903, 350));
            mariopathPoints.Add(new Point(221, 50));
            mariopathPoints.Add(new Point(144, 85));
            mariopathPoints.Add(new Point(70, 222));
            mariopathPoints.Add(new Point(70, 730));
            mariopathPoints.Add(new Point(470, 540));
            mariopathPoints.Add(new Point(722, 872));
            mariopathPoints.Add(new Point(752, 872));
            mariopathPoints.Add(new Point(903, 872));
            mariopathPoints.Add(new Point(903, 580));

            luigiPositon = new Point(935, 600);
            pathPoints.Add(new Point(935, 350));
            pathPoints.Add(new Point(221, 50));
            pathPoints.Add(new Point(144, 85));
            pathPoints.Add(new Point(70, 222));
            pathPoints.Add(new Point(70, 730));
            pathPoints.Add(new Point(470, 540));
            pathPoints.Add(new Point(722, 872));
            pathPoints.Add(new Point(752, 872));
            pathPoints.Add(new Point(903, 872));
            pathPoints.Add(new Point(903, 580));


            targetPosition = mariopathPoints[marioPointIndex];

            this.BackgroundImage = raceType == 0 ? race.Track : tracks[raceType - 1];
            RenderCharacter(CharacterID.Mario, pbMario);
            RenderCharacter(CharacterID.Luigi, pbLuigi);
        }

        private void RenderCharacter(CharacterID characterID, PictureBox pictureBox)
        {
            spriteRenderer.RenderSprite(pictureBox, characterID, 0);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void MarioCircuit()
        {
            // Calculate the distance and direction to the target position
            int deltaX = targetPosition.X - marioPosition.X;
            int deltaY = targetPosition.Y - marioPosition.Y;
            double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            double directionX = deltaX / length;
            double directionY = deltaY / length;

            // Move Mario towards the target position
            marioPosition = new Point(
                (int)(marioPosition.X + marioSpeed * directionX),
                (int)(marioPosition.Y + marioSpeed * directionY)
            );
            pbMario.Location = marioPosition;

            // Check if Mario has reached the target position
            if (Math.Abs(marioPosition.X - targetPosition.X) < marioSpeed &&
                Math.Abs(marioPosition.Y - targetPosition.Y) < marioSpeed)
            {
                // Mark the current target position as visited
                marioVisitedPoints.Add(targetPosition);

                // Move to the next target position if available and not visited
                for (int i = marioPointIndex + 1; i < mariopathPoints.Count; i++)
                {
                    if (!marioVisitedPoints.Contains(mariopathPoints[i]))
                    {
                        marioPointIndex = i;
                        targetPosition = mariopathPoints[marioPointIndex];
                        break;
                    }
                }
            }
            CheckForStop(CharacterID.Mario, marioPosition);
            UpdateCharacters();
        }


        //same logic as mario
        private void LuigiCircuit()
        {
            int deltaX = targetPosition.X - luigiPositon.X;
            int deltaY = targetPosition.Y - luigiPositon.Y;
            double length = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            double directionX = deltaX / length;
            double directionY = deltaY / length;

            luigiPositon = new Point(
                (int)(luigiPositon.X + luigiSpeed * directionX),
                (int)(luigiPositon.Y + luigiSpeed * directionY)
            );
            pbLuigi.Location = luigiPositon;

            if (Math.Abs(luigiPositon.X - targetPosition.X) < luigiSpeed &&
                Math.Abs(luigiPositon.Y - targetPosition.Y) < luigiSpeed)
            {
                luigiVisitedPoints.Add(targetPosition);

                for (int i = luigiPointIndex + 1; i < pathPoints.Count; i++)
                {
                    if (!luigiVisitedPoints.Contains(pathPoints[i]))
                    {
                        luigiPointIndex = i;
                        targetPosition = pathPoints[luigiPointIndex];
                        break;
                    }
                }
            }

            CheckForStop(CharacterID.Luigi, luigiPositon);
            UpdateCharacters();
        }


        private void CheckForStop(CharacterID character, Point position)
        {
            foreach (Point stopPoint in pathPoints)
            {
                // Check if the character's position is within the vicinity of a stop point
                if (Math.Abs(position.X - stopPoint.X) < 20 && Math.Abs(position.Y - stopPoint.Y) < 20)
                {
                    // Generate a random number, if it's divisible by 4, stop the character
                    if (random.Next(1, 101) % 100 == 0)
                    {
                        // Stop the character by disabling its tick timer
                        switch (character)
                        {
                            case CharacterID.Mario:
                                Mariotick.Enabled = false;
                                stopMario.Enabled = true;
                                marioPointIndex++;
                                break;
                            case CharacterID.Luigi:
                                LuigiTick.Enabled = false;
                                stopMario.Enabled = true;
                                luigiPointIndex++;
                                break;
                            case CharacterID.Bowser:
                                BowserTick.Enabled = false;
                                stopMario.Enabled = true;
                                break;
                            case CharacterID.Peach:
                                PeachTick.Enabled = false;
                                stopMario.Enabled = true;
                                break;
                        }

                        if (!charactersStopping.Contains(character))
                        {
                            charactersStopping.Add(character);
                        }
                        break; // Break out of the loop once a stop point is found
                    }
                }
            }
        }

        private void UpdateCharacters()
        {
            if (charactersStopping.Count == 4)
            {
                stopTimer.Start();
            }
        }


        private void StartRace()
        {

        }

        private void tick_Tick(object sender, EventArgs e)
        {
            MarioCircuit();

        }
        private void LuigiTick_Tick(object sender, EventArgs e)
        {
            LuigiCircuit();
        }
        private void PeachTick_Tick(object sender, EventArgs e)
        {
            
        }
        private void BowserTick_Tick(object sender, EventArgs e)
        {
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }


        private void frmGame_Load(object sender, EventArgs e)
        {
            Mariotick.Enabled = true;
            LuigiTick.Enabled = true;
            PeachTick.Enabled = true;
            BowserTick.Enabled = true;
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

        private void stop_Tick(object sender, EventArgs e)
        {
            // Stop timer elapsed, reset characters' tick timers and clear character stopping list
            Mariotick.Enabled = true;
            LuigiTick.Enabled = true;
            BowserTick.Enabled = true;
            PeachTick.Enabled = true;
            charactersStopping.Clear();
            stopTimer.Stop();
        }
    }
}