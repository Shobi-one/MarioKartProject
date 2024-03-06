using System;
using System.Drawing;
using System.Drawing.Text;
using System.Windows.Forms;
using System.IO;

namespace HorseRacing
{
    public class FontManager
    {
        public static Font LoadEmbeddedFont(float size)
        {
            PrivateFontCollection fontCollection = new PrivateFontCollection();
            string fontFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"assets\font\super-mario-kart.ttf");

            if (File.Exists(fontFilePath))
            {
                fontCollection.AddFontFile(fontFilePath);
                return new Font(fontCollection.Families[0], size, FontStyle.Regular);
            }
            else
            {
                MessageBox.Show("Font file not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null; // Or you can return a default font
            }
        }
    }
}

