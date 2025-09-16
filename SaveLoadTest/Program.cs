using System;
using System.IO;
namespace owd
{
    class Program
    {
        static void Main()
        {
            string filePath = "testsave.json";

            // Create test data
            var player = new PlayerData
            {
                Name = "Alice",
                Level = 5,
                Score = 12345
            };

            // Save it
            BepinexSaveLoad.Save(player, filePath);
            Console.WriteLine("Data saved!");

            // Load it back
            var loadedPlayer = BepinexSaveLoad.Load<PlayerData>(filePath);
            Console.WriteLine("Data loaded!");

            // Print results
            Console.WriteLine($"Name: {loadedPlayer.Name}, Level: {loadedPlayer.Level}, Score: {loadedPlayer.Score}");

        }
    }

    public class PlayerData
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Score { get; set; }
    }
}
