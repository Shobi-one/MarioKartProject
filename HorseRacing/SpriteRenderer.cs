using System;
using System.Drawing;
using System.Windows.Forms;

namespace HorseRacing
{
    public class SpriteRenderer
    {
        private Bitmap spriteSheet;
        private int spritesPerCharacter = 12;
        private Point position;

        public SpriteRenderer()
        {
            this.spriteSheet = Properties.Resources.spritesheet;
            this.position = Point.Empty; // Initialize position to (0, 0)
        }

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }

        public void RenderSprite(PictureBox pictureBox, CharacterID characterID, int spriteIndex)
        {
            if (spriteSheet == null)
            {
                throw new InvalidOperationException("Sprite sheet not loaded.");
            }

            // Determine sprite position in sprite sheet
            int spriteWidth = 32;
            int spriteHeight = 32;
            int columns = spriteSheet.Width / spriteWidth;

            // Determine row and column based on character and sprite index
            int characterOffset = (int)characterID * spritesPerCharacter;
            int row = (characterOffset + spriteIndex) / columns;
            int column = (characterOffset + spriteIndex) % columns;

            // Create a bitmap to hold the extracted sprite
            Bitmap sprite = new Bitmap(spriteWidth, spriteHeight);

            // Copy the sprite from the sprite sheet to the new bitmap
            using (Graphics g = Graphics.FromImage(sprite))
            {
                // Set interpolation mode to high quality
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                // Draw the sprite with interpolation
                g.DrawImage(spriteSheet, new Rectangle(0, 0, spriteWidth, spriteHeight),
                            new Rectangle(column * spriteWidth, row * spriteHeight, spriteWidth, spriteHeight),
                            GraphicsUnit.Pixel);
            }

            // Display the extracted sprite in the PictureBox
            pictureBox.Image = sprite;

            // Set the position of the sprite
            pictureBox.Location = position;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }
    }
}