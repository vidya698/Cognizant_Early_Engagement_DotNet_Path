using System;
using System.IO;

public class Program      //DO NOT change the class name
{
    //implement code here
    public static void Main(string[] args)
    {
        File.Copy("sample1.txt","sample2.txt", true);
        
        Console.WriteLine("From sample1.txt");
        Console.WriteLine(File.ReadAllText("sample1.txt"));
        
        Console.WriteLine("From sample2.txt");
        Console.WriteLine(File.ReadAllText("sample2.txt"));
    }
}