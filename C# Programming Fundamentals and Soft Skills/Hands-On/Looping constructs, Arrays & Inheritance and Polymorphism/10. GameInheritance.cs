using System;

public class Game
{
    public string Name { get; set; }
    public int MaxNumPlayers { get; set; }
    
    public override string ToString()
    {
        return ("Maximum number of players for " + Name + " is " + MaxNumPlayers);
    }
}

public class GameWithTimeLimit : Game
{
    public int TimeLimit { get; set; }
    
    public override string ToString()
    {
        Console.WriteLine(base.ToString());
        return ("Time Limit for " + Name + " is " + TimeLimit + " minutes");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Game g = new Game();
        GameWithTimeLimit gt = new GameWithTimeLimit();
        
        Console.WriteLine("Enter a game");
        g.Name = Console.ReadLine();
        
        Console.WriteLine("Enter the maximum number of players");
        g.MaxNumPlayers = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter a game that has time limit");
        gt.Name = Console.ReadLine();
        
        Console.WriteLine("Enter the maximum number of players");
        gt.MaxNumPlayers = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the time limit in minutes");
        gt.TimeLimit = int.Parse(Console.ReadLine());
        
        Console.WriteLine(g.ToString());
        Console.WriteLine(gt.ToString());
    }
}