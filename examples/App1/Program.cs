using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Game g = new Game();
        g.Run();
    }
}

public class Game
{
    public Player Player { get; set; }
    public void Run()
    {
        Console.WriteLine("Game is Running");
        Console.WriteLine("What is your name");
        string playerName = Console.ReadLine();
        Console.WriteLine($"Hello {playerName}!");

        Player p = new Player(playerName);

        Console.WriteLine($"What Kind Of Insect Would you Like To Adopt {p.Name}?");
        string insectScientifictName = Console.ReadLine();
        Console.WriteLine($"You Want to Adpot a {insectScientifictName}");
        Insect insect = new Insect(insectScientifictName);
        p.Adopt(insect);

        Console.WriteLine($"{p.Name} adopted {p.Pet.ScientificName}");
        Console.WriteLine($"Would You Like To Give Your Insect A Pet Name?");
        string petName = Console.ReadLine();
        p.Pet.PetName = petName;
        Console.WriteLine($"Your {p.Pet.ScientificName} is Now Known as {p.Pet.PetName}");
    }
}

public class Player
{
    public Player(string name)
    {
        this.Name = name;
        this.Pet = null;
    }
    public string Name { get; set; }
    public Insect Pet { get; set; }

    public void Adopt(Insect insect)
    {
        this.Pet = insect;
    }
}

public class Insect
 {
    public Insect(string scientificName)
    {
        this.ScientificName = scientificName;
        this.PetName = string.Empty;
    }

    public string ScientificName { get; set; }
    public string PetName { get; set; }
}

// public class Food
// {

// }

// public class Habitat
// {

// }
