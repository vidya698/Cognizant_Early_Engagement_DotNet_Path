using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    public static void Main(string[] args)
    {
        string first_name, last_name, fullName;
        
        Console.WriteLine("\"Enter first name");
        first_name = Console.ReadLine();
        
        Console.WriteLine("Enter last name");
        last_name = Console.ReadLine();
        
        fullName = first_name + " " + last_name;
        Console.WriteLine("Full name : {0}", fullName);
    }
}
