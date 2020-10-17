using System;
using System.IO;
public class Program      //DO NOT change the class name
{
    //implement code here
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the Sentence");
       
        string i = Console.ReadLine();
        File.AppendAllText("sentences.txt", i + Environment.NewLine); 
        i = Console.ReadLine();
        File.AppendAllText("sentences.txt", i); 
        string readText = File.ReadAllText("sentences.txt");
        Console.WriteLine(readText);
    }
}
