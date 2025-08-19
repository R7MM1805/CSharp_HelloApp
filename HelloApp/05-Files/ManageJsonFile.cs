using System.Text.Encodings.Web;
using System.Text.Json;

partial class Program
{
    public static readonly JsonSerializerOptions options = new() { WriteIndented = true, Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping };
    public static void ManageJsonFile()
    {
        string filePath = "../../../05-Files/Characters.json";
        List<Character> characters =
        [
            new(1, "Peter Parker", "Spider", "Avengers"),
            new(2, "Tony Stark", "Iron Man", "Avengers"),
            new(3, "Steve Rogers", "Capitán América", "Avengers")
        ];
        string json = JsonSerializer.Serialize(characters, 
            options: options);
        File.WriteAllText(filePath, json);
        string charactersFromFile = File.ReadAllText(filePath);
        List<Character>? characterList = JsonSerializer.Deserialize<List<Character>>(charactersFromFile);
        if (characterList is null || characterList.Count == 0)
        {
            WriteLine("No hay datos en el json");
            return;
        }
        characterList.ForEach(x => WriteLine($"ID: {x.ID}, Nombre: {x.Name}, Alias: {x.Alias}, Team: {x.Team}"));
    }
    class Character(int id, string name, string alias, string team)
    {
        public int ID { get; set; } = id;
        public string Name { get; set; } = name;
        public string Alias { get; set; } = alias;
        public string Team { get; set; } = team;
    }
}