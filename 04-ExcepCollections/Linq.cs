partial class Program
{

    static void Linq()
    {


        List<int> numbers = [1, 2, 3, 4, 5, 6];
        List<int> evenNumbers = [];

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        //sintaxis de consulta
        var evenNumbersQuery = from num in numbers
                               where num % 2 == 0
                               select num;

        //sintaxis de metodo
        var evenNumbersMethod = numbers.Where(n => n % 2 == 0);
        foreach (var number in evenNumbersMethod)
        {
            WriteLine(number);
        }

        //consultas simples
        List<MarvelCharacter> characters = new List<MarvelCharacter>
        {
            new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
            new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
            new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
            new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        };

        WriteLine("Personajes quepertenecen a los avengers");
        var avengersQuery = from c in characters
                            where c.Team == "Avengers"
                            select $"{c.Alias} {c.Name}";

        var avengersMethod = characters.Where(c => c.Team == "Avengers");
        foreach (var character in avengersMethod)
        {
            WriteLine($"{character.Alias} {character.Name}");
        }

        var uppercaseNamesQuery = from c in characters
                                  select c.Name?.ToUpper();
        var uppercaseNamesMethod = characters.Select(c => c.Name?.ToUpper());

        WriteLine("Los nombres en mayusculas");
        foreach (var name in uppercaseNamesQuery)
        {
            WriteLine(name);
        }

    }
}

class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}

