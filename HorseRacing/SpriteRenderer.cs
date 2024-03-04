using System;
using System.Drawing;
using System.Windows.Forms;

namespace HorseRacing
{
    public class SpriteRenderer
    {
        private Bitmap spriteSheet;

        public SpriteRenderer(Bitmap spriteSheet)
        {
            this.spriteSheet = spriteSheet;
        }

        public void RenderSprite(PictureBox pictureBox, int spriteIndex)
        {
            if (spriteSheet == null)
            {
                throw new InvalidOperationException("Sprite sheet not loaded.");
            }

            // Determine sprite position in sprite sheet
            int spriteWidth = 32;
            int spriteHeight = 32;
            int columns = spriteSheet.Width / spriteWidth;
            int row = spriteIndex / columns;
            int column = spriteIndex % columns;

            // Create a bitmap to hold the extracted sprite
            Bitmap sprite = new Bitmap(spriteWidth, spriteHeight);

            // Copy the sprite from the sprite sheet to the new bitmap
            using (Graphics g = Graphics.FromImage(sprite))
            {
                g.DrawImage(spriteSheet, new Rectangle(0, 0, spriteWidth, spriteHeight),
                            new Rectangle(column * spriteWidth, row * spriteHeight, spriteWidth, spriteHeight),
                            GraphicsUnit.Pixel);
            }

            // Display the extracted sprite in the PictureBox
            pictureBox.Image = sprite;
        }
    }
}
