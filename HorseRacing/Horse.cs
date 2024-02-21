using System;

namespace HorseRacing
{
    public class Horse
    {
        private string name { get; set; }
        private int speed { get; set; }

        public Horse(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }

        public static Horse GenerateHorse()
        {
            Random random = new Random();
            string[] possibleNames = { "Thunder", "Blaze", "Swift", "Shadow", "Spirit" }; // Sample horse names will grab them from file in the future
            string name = possibleNames[random.Next(possibleNames.Length)];
            int speed = random.Next(5, 15);
            return new Horse(name, speed);
        }
    }
}
