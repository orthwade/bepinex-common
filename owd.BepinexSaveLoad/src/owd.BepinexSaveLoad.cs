using System.IO;
using System.Text.Json;

namespace owd
{
    public static class BepinexSaveLoad
    {
        private static readonly JsonSerializerOptions Options = new JsonSerializerOptions
        {
            WriteIndented = true,
            IncludeFields = true,
            PropertyNameCaseInsensitive = true
        };

        // Save to file
        public static void Save<T>(T obj, string filePath)
        {
            string json = JsonSerializer.Serialize(obj, Options);
            File.WriteAllText(filePath, json);
        }

        // Load from file
        public static T Load<T>(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("File not found", filePath);

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(json, Options);
        }

    }
}