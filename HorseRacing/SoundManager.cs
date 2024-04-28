using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace HorseRacing
{
    public class SoundManager
    {
        private Dictionary<string, SoundPlayer> soundPlayers;

        public SoundManager()
        {
            soundPlayers = new Dictionary<string, SoundPlayer>();
        }

        public void LoadSound(string soundName, string fileName, bool loopable, bool playImmediately = false)
        {
            string songFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"assets\sfx\" + fileName);
            if (!soundPlayers.ContainsKey(soundName))
            {
                SoundPlayer player = new SoundPlayer(songFilePath);
                player.LoadCompleted += (sender, e) =>
                {
                    if (loopable)
                    {
                        ((SoundPlayer)sender).PlayLooping();
                    }
                    if (playImmediately && !loopable)
                    {
                        ((SoundPlayer)sender).Play();
                    }
                };
                player.LoadAsync();  // Ensure you are loading asynchronously
                soundPlayers.Add(soundName, player);
            }
        }

        public void PlaySound(string soundName)
        {
            if (soundPlayers.ContainsKey(soundName))
            {
                soundPlayers[soundName].Play();
            }
            else
            {
                MessageBox.Show("Sound not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void StopSound(string soundName)
        {
            if (soundPlayers.ContainsKey(soundName))
            {
                soundPlayers[soundName].Stop();
            }
        }

        // Additional methods for managing sounds can be added here, such as pause, resume, volume control, etc.
    }
}
