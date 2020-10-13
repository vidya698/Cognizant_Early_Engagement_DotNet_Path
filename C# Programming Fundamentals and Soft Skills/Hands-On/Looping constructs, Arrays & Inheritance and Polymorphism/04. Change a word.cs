using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a string");
        string str = Console.ReadLine();
        if(str.Contains("the"))
        {
            str = str.Replace("the","that");
            Console.WriteLine(str);
        } else 
        {
            Console.WriteLine("Word 'the' not found");
        }
    }
}
