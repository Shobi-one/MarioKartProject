using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HorseRacing
{
    public class Horse
    {
        public string Name { get; set; }
        public int Speed { get; set; }
        public int SpriteIndex { get; set; }

        public Horse(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
        public static Horse GenerateHorse()
        {
            Random random = new Random();
            string[] possibleNames = { "Thunder", "Fury", "Lightning", "Strike", "Storm", "Dancer", "Midnight", "Dreamer", "Starlight", "Express", "Moonbeam", "Runner", "Blaze", "Swift", "Shadow", "Spirit", "Fireball" }; // Sample horse names will get from a file in the future
            string name = possibleNames[random.Next(possibleNames.Length)];
            int speed = random.Next(5, 30);
            return new Horse(name, speed);
        }
    }
}
