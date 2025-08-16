using AdvanceLinq;

namespace AdvanceLinq
{
    class Character(int id, string name, string alias, string team)
    {
        public int Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string Alias { get; set; } = alias;
        public string Team { get; set; } = team;
    }

    class Ability(int characterID, string description)
    {
        public int CharacterId { get; set; } = characterID;
        public string Description { get; set; } = description;
    }
    class Statistic(int characterID, int power)
    {
        public int CharacterId { get; set; } = characterID;
        public int Power { get; set; } = power;
    }
}
partial class Program
{
    public static void AdvanceLinq()
    {
        List<AdvanceLinq.Character> characters =
        [
            new AdvanceLinq.Character(1, "Peter Parker", "Spider-Man", "Avengers"),
            new AdvanceLinq.Character(2, "Tony Stark", "Iron Man", "Avengers"),
            new AdvanceLinq.Character(3, "Steve Rogers", "Capitán América", "Avengers"),
            new AdvanceLinq.Character(4, "T'Challa", "Black Panther", "Wakanda"),
            new AdvanceLinq.Character(5, "Stephen Strange", "Doctor Strange", "Defenders")
        ];
        List<Ability> abilities =
        [
            new Ability(1, "Sentido arácnido"),
            new Ability(1, "Trepar paredes"),
            new Ability(2, "Inteligencia y armadura de alta tecnología"),
            new Ability(3, "Super fuerza"),
            new Ability(4, "Reflejos aumentados"),
            new Ability(5, "Magia y hechicería")
        ];
        List<Statistic> statistics =
        [
            new Statistic(1, 85),
            new Statistic(2, 90),
            new Statistic(3, 88),
            new Statistic(4, 80),
            new Statistic(5, 95)
        ];
        IEnumerable<IGrouping<string, AdvanceLinq.Character>> groupByTeam = characters.GroupBy(x => x.Team);
        foreach (IGrouping<string, AdvanceLinq.Character> group in groupByTeam)
        {
            WriteLine($"Equipo: {group.Key}");
            ShowCharactersAndAbilities(abilities, [.. group]);
        }
        WriteLine("INFORMACIÓN ADICIONAL");
        GetTotalPower(statistics);
        GetAverageAvengersPower(statistics, characters);
        WriteLine("HABILIDADES POR PERSONAJE");
        GetTotalAbiliterPerCharacter(characters, abilities);
    }
    private static void ShowCharactersAndAbilities(List<Ability> abilities, List<AdvanceLinq.Character> characters)
    {
        foreach (AdvanceLinq.Character character in characters)
        {
            WriteLine($"{character.Name} - {character.Alias}");
            WriteLine("Habilidades: ");
            ShowAbilities(abilities, character.Id);
        }
    }
    private static void ShowAbilities(List<Ability> abilities, int characterID)
    {
        List<string> descriptions = [.. abilities.Where(x => x.CharacterId == characterID).Select(x => x.Description)];
        descriptions.ForEach(WriteLine);
    }
    private static void GetTotalPower(List<Statistic> statistics)
    {
        int totalPower = statistics.Sum(x => x.Power);
        WriteLine($"Poder total de personajes: {totalPower}");
    }
    private static void GetAverageAvengersPower(List<Statistic> statistics, List<AdvanceLinq.Character> characters)
    {
        double avengersPower = (from c in characters
                             join s in statistics on c.Id equals s.CharacterId
                             where c.Team == "Avengers"
                             select s.Power).Average();
        WriteLine($"Promedio de poder de los avengers: {avengersPower:F2}");
    }
    private static void GetTotalAbiliterPerCharacter(List<AdvanceLinq.Character> characters, List<Ability> abilities)
    {
        List<string> groupJoin = [.. (from c in characters
                                join a in abilities on c.Id equals a.CharacterId
                                group a by c.Alias into groupAbilities
                                select $"Alias: {groupAbilities.Key} - Cantidad Habilidades: {groupAbilities.Count()}")];
        groupJoin.ForEach(WriteLine);
    }
}