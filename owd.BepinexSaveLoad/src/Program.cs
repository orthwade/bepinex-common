using System;
using System.IO;

namespace owd
{
    class Program
    {
        static void Main()
        {
            string filePath = "testsave.json";

            var player = new PlayerData
            {
                Name = "Alice",
                Level = 5,
                Score = 12345
            };

            BepinexSaveLoad.Save(player, filePath);
            Console.WriteLine("Data saved!");

            var loadedPlayer = BepinexSaveLoad.Load<PlayerData>(filePath);
            Console.WriteLine("Data loaded!");

            Console.WriteLine($"Name: {loadedPlayer.Name}, Level: {loadedPlayer.Level}, Score: {loadedPlayer.Score}");

            File.Delete(filePath); // optional cleanup
        }
    }

    public class PlayerData
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int Score { get; set; }
    }
}
