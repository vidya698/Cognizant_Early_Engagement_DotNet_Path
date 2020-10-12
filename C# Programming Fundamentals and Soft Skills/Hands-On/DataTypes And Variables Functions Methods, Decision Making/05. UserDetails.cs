using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    
    static void Main(string[] args)
    {
        string name, city;
        float age;
        char gender;
        long mobile, pincode;
        
        Console.WriteLine("Enter name");
        name = Console.ReadLine();
        
        Console.WriteLine("Enter age(completed years and months)");
        age = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter gender('M' for Male and 'F' for Female)");
        gender = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("Enter city");
        city = Console.ReadLine();
        
        Console.WriteLine("Enter mobile number");
        mobile = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine("Enter pincode");
        pincode = Convert.ToInt64(Console.ReadLine());
        
        
        Console.WriteLine("Name : {0}", name);
        Console.WriteLine("Age : {0}", age);
        Console.WriteLine("Gender : {0}", gender);
        Console.WriteLine("City : {0}", city);
        Console.WriteLine("Mobile : {0}", mobile);
        Console.WriteLine("Pincode : {0}", pincode);
    }
}