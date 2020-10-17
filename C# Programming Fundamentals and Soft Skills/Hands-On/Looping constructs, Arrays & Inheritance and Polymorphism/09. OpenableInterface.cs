using System;

public interface IOpenable
{
    String OpenSesame();
}

public class TreasureBox : IOpenable
{
    public String OpenSesame()
    {
        return "Congratulations , Here is your lucky win";
    }
}

public class Parachute : IOpenable
{
    public String OpenSesame()
    {
        return "Have a thrilling experience flying in air";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TreasureBox t = new TreasureBox();
        Parachute p = new Parachute();
        
        Console.WriteLine("Enter the letter found in the paper");
        char ch = Console.ReadLine()[0];
        
        if(ch == 'T')
            Console.WriteLine(t.OpenSesame());
        else if(ch == 'P')
            Console.WriteLine(p.OpenSesame());
    }
}