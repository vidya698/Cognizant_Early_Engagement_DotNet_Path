using System;

namespace ProgFundamentals2 
{
    public class Program      //DO NOT change the class name
    {
        //implement code here
        static void Main(string[] args)
        {
            long num1, num2;
            
            Console.WriteLine("Enter large number 1:");
            num1 = Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("Enter large number 2:");
            num2= Convert.ToInt64(Console.ReadLine());
            
            Console.WriteLine("The result is: " + (num1+num2));
        }
    }
}