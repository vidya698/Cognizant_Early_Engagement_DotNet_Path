using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    static void Main(string[] args)
    {
        int x, y;
        bool result;
        
        Console.WriteLine("Enter the value for x");
        x = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the value for y");
        y = Convert.ToInt32(Console.ReadLine());
        
        result = x < y;
        
        Console.WriteLine("The result of whether {0} is less than {1} is {2}", x, y, result);
    }
}