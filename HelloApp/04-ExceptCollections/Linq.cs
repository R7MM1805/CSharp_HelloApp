partial class Program
{
    public static void Linq()
    {
        List<int> numbers = [1, 2, 3, 4, 5, 6];
        List<int> evenNumber = [];
        WriteLine("Uso de Tradicional");
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
                evenNumber.Add(number);
        }
        foreach (int number in evenNumber)
        {
            WriteLine(number);
        }
        WriteLine("Uso de LinQ");
        WriteLine("Forma Querys");
        evenNumber = [.. from num in numbers where num % 2 == 0 select num];
        evenNumber.ForEach(WriteLine);
        WriteLine("Forma Method");
        evenNumber = [.. numbers.Where(x => x % 2 == 0)];
        evenNumber.ForEach(WriteLine);

        /* Consultas simples */
        List<MarvelCharacter> characters =
        [
            new("Peter Parker", "Spider-Man", "Avengers"),
            new("Tony Stark", "Iron Man", "Avengers"),
            new("Steve Rogers", "Captain America", "Avengers"),
            new("Natasha Romanoff", "Black Widow", "Avengers"),
            new("T'Challa", "Black Panther", "Wakanda"),
            new("Stephen Strange", "Doctor Strange", "Defenders")
        ];
        //Mostrar personajes del team Avengers
        WriteLine("Personajes del team avengers");
        List<string> avengersQuery = [.. characters.Where(x => x.Team == "Avengers").Select(x => $"{x.Name} - {x.Alias}")];
        avengersQuery.ForEach(x => WriteLine(x.ToUpper()));
        WriteLine("Personajes ordenados");
        List<string> sortedCharacters = [.. characters.OrderBy(x => x.Name).Select(x => x.Name)];
        sortedCharacters.ForEach(x => WriteLine(x.ToUpper()));
        WriteLine("Personajes 3 elementos");
        List<string> firstThreeElements = [.. characters.Take(3).Select(x => x.Name)];
        firstThreeElements.ForEach(x => WriteLine(x.ToUpper()));
    }
    class MarvelCharacter(string name, string alias, string team)
    {
        public string Name { get; set; } = name;
        public string Alias { get; set; } = alias;
        public string Team { get; set; } = team;
    }
}